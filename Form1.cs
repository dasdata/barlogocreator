using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Net.Http.Headers;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Xml;



namespace BarLogoCreator
{
    public partial class Form1 : Form
    {
        _Db _Db = new _Db();   // <= keys api from openai
        // let's make a folder on desktop called LOGO to store generated files
        string _folderName = "Logo_"+ DateTime.Now.ToString("yyMMdd"); // generated folder 
        public string _tempImageDire = System.IO.Path.GetTempPath();
        public string _DesktopImageDire = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // set on the desktop 

        private BackgroundWorker picGen = new BackgroundWorker();

        public Form1()
        {
            InitializeComponent();

            // let build it
            cmdAddToInterface();
              
        }

        void cmdAddToInterface()
        {
            lblLoading.Visible = false;

            // Add some popular industries to the ComboBox
            cbIndustries.Items.Add("Technology");
            cbIndustries.Items.Add("Finance");
            cbIndustries.Items.Add("Retail");
            cbIndustries.Items.Add("Healthcare");
            cbIndustries.Items.Add("Manufacturing");
            cbIndustries.Items.Add("Education");
            cbIndustries.Items.Add("Government");
            cbIndustries.Items.Add("Media and entertainment");
            cbIndustries.Items.Add("Transportation");
            cbIndustries.Items.Add("Hospitality");
            cbIndustries.Items.Add("Agriculture");
            cbIndustries.Items.Add("Construction");
            cbIndustries.Items.Add("Energy");
            cbIndustries.Items.Add("Mining");
            cbIndustries.Items.Add("Real estate");
            cbIndustries.Items.Add("Telecommunications");
            cbIndustries.Items.Add("Tourism");
            cbIndustries.Items.Add("Utilities");
            cbIndustries.Items.Add("Non-profit");
            cbIndustries.Items.Add("Government");
            cbIndustries.SelectedIndex = 0;

            // logo styles
            cbStyles.Items.Add("Minimalist");
            cbStyles.Items.Add("Professional");
            cbStyles.Items.Add("Vintage");
            cbStyles.Items.Add("Modern");
            cbStyles.Items.Add("Abstract");
            cbStyles.Items.Add("Classic");
            cbStyles.Items.Add("Chic");
            cbStyles.Items.Add("Elegant");
            cbStyles.Items.Add("Playful");
            cbStyles.Items.Add("Sophisticated");
            cbStyles.SelectedIndex = 0;

            // colors schemes  
            List<string> colorSchemes = new List<string>() { "Black and White",  "White and Silver",  "Silver and Gray",
                  "Red and Black",  "Orange and Blue", "Yellow and Green",  "Green and White",  "Blue and Silver",  "Purple and Pink",  "Pink and Black",
                         "Gray and Maroon", "Maroon and Navy",  "Navy and Teal",  "Teal and Olive",
                        "Olive and Lime",  "Red, Yellow, and Blue", "Green, White, and Black",  "Pink, Purple, and Blue",  "Gold and Brown",
                        "Pink, Purple, and Green",  "Cyan and Magenta",  "Yellow, Orange, and Red" };
            foreach (string colorScheme in colorSchemes)
            {
                lbColors.Items.Add(colorScheme);
            } 
            lbColors.SelectedIndex = 0;

            // add stylish
            List<string> logoStylish = new List<string>() {"3D", "Piexl", "Sketch", "Retro", "Cartoon", "Geometric", "Neon", "Clay", "Abstract", "Lineal"   };

            foreach (string logoStyle in logoStylish)
            {
                cmbTheme.Items.Add(logoStyle);
            }
            cmbTheme.SelectedIndex = 0;


            // add some styles
            List<string> logoTypes = new List<string>() { "Mascot Logo", "Emblem", "Icon", "Wordmark", "Combination Mark", "Abstract Logo",  "Letterform", "Typographic Logo", "Hand-Drawn Logo" };

            foreach (string logoType in logoTypes)
            {
                cbxLogoStyle.Items.Add(logoType);
            }
            cbxLogoStyle.SelectedIndex = 0;

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folderPath = Path.Combine(desktopPath, _folderName);

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

        }

 

        public async Task cmdMakePicAsync()
        {
            List<Image> images = new List<Image>();
            var task = cmdGenerateImageAsync(txtPrompt.Text, 4);  // generate 4 variants
            //  var task = cmdGenerateContentAsync(value);
            string _generateContet = await task;
            string[] imagesFiles = _generateContet.Split('|');

            List<string> imagePaths = new List<string>();

            foreach (string image in imagesFiles)
            {
                string _imageOnDisk = _DesktopImageDire + "/" + _folderName + "/" + image;
                images.Add(Image.FromFile(_imageOnDisk));
                ConvertPngToSvg(_imageOnDisk, _imageOnDisk.Replace("png", "svg"));
                lblResult.Text += " " + image;
            }

            int i = 0;
            foreach (Image image in images)
            {
                switch (i)
                {
                    case 0:
                        picResult.Image = image;  
                        break;
                    case 1:
                        picResult1.Image = image; 
                        picResult1.Visible = true;
                        break;
                    case 2:
                        picResult2.Image = image; 
                        picResult2.Visible = true;
                        break;
                    default:
                        picResult3.Image = image; 
                        picResult3.Visible = true;
                        break;
                }
                i++;

                // Pause execution for 1 second
                System.Threading.Thread.Sleep(1000);
            }

            lblLoading.Visible= false;
            MessageBox.Show("Pics were generated");
            //   txtPrompt.Text = "";

        }

        // generate pictures using dalle-2
        public async Task<string> cmdGenerateImageAsync(string _prompt, int _NoImg)
        {
            string _filesArray = "";
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(_Db._oAIImages),
                Headers = { { "Authorization", "Bearer " + _Db._oiKey }, },     //  256x256    512x512   1024x1024
                Content = new StringContent("{\n    \"prompt\": \"" + _prompt + "\",\n    \"n\": " + _NoImg + ",\n    \"size\": \"256x256\" \n}")
                {
                    Headers = { ContentType = new MediaTypeHeaderValue("application/json") }
                }
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                JToken o = JObject.Parse(body);
                // _resultGen = o.SelectToken("data").ToString();
                JArray _content = (JArray)o["data"];
                // Loop through the array of image URLs
                for (int i = 0; i < _content.Count; i++)
                {
                    string _fileRandomName = i + "_" + System.IO.Path.GetRandomFileName(); // make random file names
                    _filesArray += _fileRandomName + ".png|";
                    using (WebClient webClient = new WebClient())    // Download the image from the URL
                    {
                        // store files into the Logo folder on desktop 
                        webClient.DownloadFile((string)_content[i]["url"], _DesktopImageDire + "/"+ _folderName + "/" + _fileRandomName + ".png"); 
                    }
                }
            }
            _filesArray = _filesArray.Remove(_filesArray.Length - 1, 1); // remove the last character
            return _filesArray;
        }

        // add moderation for your prompts
        public async Task<bool> cmdModerateAsync(string _input)
        {
            bool _statusResponse = false;

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(_Db._oAIModeration),
                Headers =
                     {
                       { "Authorization", "Bearer "+ _Db._oiKey },
                     },
                Content = new StringContent("{\"input\": \"" + _input + "\"}")
                { Headers = { ContentType = new MediaTypeHeaderValue("application/json") } }
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                JToken deserialized = JObject.Parse(body);
                string myResult = deserialized.SelectToken("results").ToString();

                if (myResult.Contains("true")) { _statusResponse = true; }
            }

            return _statusResponse;

        }

        // make logo button
        private void btnMakeLogo_Click(object sender, EventArgs e)
        {
            lblLoading.Text = "loading ... ";
            lblLoading.Visible = true;
            cmdMakePicAsync();
        }

        // build prompt based on selections
        void cmdMakeLogoPrompt()
        {
            try
            {
                txtPrompt.Text = ""+ cbxLogoStyle.SelectedItem.ToString() +" for " + txtBrandName.Text +
                  ", " + txtProduct.Text +
                  ", extremly balanced, centered, " + cbStyles.SelectedItem.ToString() + " " +
                  ", " + cbIndustries.SelectedItem.ToString() +
                   ", stilished as " + cmbTheme.SelectedItem.ToString() +
                  ", vivid colors of " + lbColors.SelectedItem.ToString() +
                  ", white background, no shadows, unique  ";
            }
            catch { }

        }

        public static void ConvertPngToSvg(string pngFilePath, string svgFilePath)
        {
            Bitmap bmp = new Bitmap(pngFilePath);
            using (MemoryStream ms = new MemoryStream())
            {
                bmp.Save(ms, ImageFormat.Png);
                ms.Position = 0;

                string svgXml = string.Format(
                    "<svg xmlns='http://www.w3.org/2000/svg' xmlns:xlink='http://www.w3.org/1999/xlink' width='{0}' height='{1}'> " +
                    "<rect width='100%' height='100%' fill='url(#img)' /> " +
                    "<defs> " +
                    "<pattern id='img' patternUnits='userSpaceOnUse' width='{0}' height='{1}'> " +
                    "<image xlink:href='data:image/png;base64,{2}' width='{0}' height='{1}' /> " +
                    "</pattern> " +
                    "</defs> " +
                    "</svg>",
                    bmp.Width, bmp.Height,
                    Convert.ToBase64String(ms.ToArray()));

                File.WriteAllText(svgFilePath, svgXml);
            }
        }



        private void txtBrandName_TextChanged(object sender, EventArgs e)
        {
            cmdMakeLogoPrompt();
        }

        private void txtProduct_TextChanged(object sender, EventArgs e)
        {
            cmdMakeLogoPrompt();
        }

        private void cbIndustries_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdMakeLogoPrompt();
        }

        private void cbStyles_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdMakeLogoPrompt();
        }

        private void lbColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdMakeLogoPrompt();
        }

        private void cbxLogoStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdMakeLogoPrompt();
        }

        private void cmbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdMakeLogoPrompt();
        }
    }
}