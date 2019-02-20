using System;

namespace SeleniumDemoCSharp{
    public class Contact : Navbar
    {
        public string iframeInputFirstname { get; set; } = "s-input-firstname";
        public string iframeInputLastname { get; set; } = "s-input-lastname";
        public string iframeButton { get; set; } = "s-button";
        public string iframeParagraphDemo { get; set; } = "s-paragraph-demo";
    }
}