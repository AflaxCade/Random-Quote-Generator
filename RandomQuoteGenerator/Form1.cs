using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Runtime.InteropServices;
using System.Drawing.Text;
using TheArtOfDevHtmlRenderer.Adapters;

namespace RandomQuoteGenerator
{
    public partial class Form1 : Form
    {
        private SpeechSynthesizer synthesizer = new SpeechSynthesizer();

        public Form1()
        {
            InitializeComponent();
        }
        private async void btnGetQuote_Click(object sender, EventArgs e)
        {
            try
            {
                // Create an instance of HttpClient to make the API call
                var client = new HttpClient();

                // Make a GET request to the API endpoint
                var response = await client.GetAsync("https://api.quotable.io/random");

                // Parse the JSON response using the Newtonsoft.Json NuGet package
                var json = await response.Content.ReadAsStringAsync();
                dynamic data = JsonConvert.DeserializeObject(json);

                // Set the text property of the label control to the quote fetched from the API
                lblQuote.Text = data.content;
                lblAuthor.Text = data.author;
            }
            catch (Exception exception)
            {
                MessageDialog.Show("Please make sure you have internet connection!");
            }
        }
        private void btnAudio_Click(object sender, EventArgs e)
        {
            // Select a female voice by specifying the gender and age hints
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);

            // Synthesize speech from the input text and play it asynchronously
            synthesizer.SpeakAsync(lblQuote.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadFont();
            AllocFont(font, this.lblHeader, 15);
        }

        // label Header custom Font

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbfont, uint cbfont
            , IntPtr pdv, [In] ref uint pcFonts);

        FontFamily ff;
        Font font;

        private void loadFont()
        {
            byte[] fontArray = RandomQuoteGenerator.Properties.Resources.Bord;
            int dataLength = RandomQuoteGenerator.Properties.Resources.Bord.Length;
            IntPtr ptrData = Marshal.AllocCoTaskMem(dataLength);
            Marshal.Copy(fontArray, 0, ptrData, dataLength);
            uint cFonts = 0;
            AddFontMemResourceEx(ptrData, (uint)fontArray.Length, IntPtr.Zero, ref cFonts);
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddMemoryFont(ptrData, dataLength);
            Marshal.FreeCoTaskMem(ptrData);
            ff = pfc.Families[0];
            font = new Font(ff, 15f, FontStyle.Regular);
        }
        private void AllocFont(Font f, Control c, float size)
        {
            FontStyle fontStyle = FontStyle.Regular;
            c.Font = new Font(ff, size, fontStyle);
        }
    }
}
