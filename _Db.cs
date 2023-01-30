using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarLogoCreator
{
    internal class _Db
    {
        public string _engineAI = "text-davinci-003";
        public string _oiKey = "xxx-xxxxxx-xxxx-xxxxxxxxx-xxxxxx-xxxx"; // change with your API key
        public string _oAICompletion = "https://api.openai.com/v1/completions";
        public string _oAIModeration = "https://api.openai.com/v1/moderations";
        public string _oAIImages = "https://api.openai.com/v1/images/generations";
    }
}
