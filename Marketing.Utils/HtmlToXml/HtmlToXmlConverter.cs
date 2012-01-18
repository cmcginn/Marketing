using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlCleaner;
using System.Xml.Linq;
namespace Marketing.Utils.HtmlToXml
{
    public class HtmlToXmlConverter
    {
        public string HtmlReplace(string source, string replacement,string replacementId)
        {
            XElement sourceElement = ConvertToXml(source);
            XElement replacementElement = ConvertToXml(replacement);
            return HtmlReplace(sourceElement, replacementElement, replacementId).ToString();
        }
        public XElement HtmlReplace(XElement sourceElement, XElement replacementElement, string replacementId)
        {
            sourceElement.DescendantsAndSelf().Where(n => n.Attribute("id") != null && n.Attribute("id").Value == replacementId).ToList().ForEach(n => n.ReplaceWith(replacementElement));
            return sourceElement;
        }
        public XElement ConvertToXml(string source)
        {
            string processed = string.Empty;
            HtmlReader reader = new HtmlReader(source);
            StringBuilder builder = new StringBuilder();
            HtmlWriter writer = new HtmlWriter(builder);
            while (!reader.EOF)
                writer.WriteNode(reader, true);
            //XML hates &nbsp;
            processed = Filter(builder.ToString(),true);
            XElement result = XElement.Parse(processed);
            return result;
        }
        public string Filter(string source,bool toSgml)
        {
            Dictionary<string, string> replacements = new Dictionary<string, string>();
            
            replacements.Add("&nbsp;", "&#160;");
            replacements.Add("&mdash;", "&#8212;");
            replacements.Add("&rsquo;","&#8217;");
            replacements.Add("&lsquo;", "&#8216;");
            replacements.Add("&middot;", "&#183;");
            replacements.Add("&ldquo", "&#8220;");
            replacements.Add("&rdquo", "&#8221;");
            replacements.Add("&ndash;", "&#8211;");
            replacements.Add("&copy;", "&#169;" );
            replacements.Add("& ", "&#38;");


            if (toSgml)
                replacements.Keys.ToList().ForEach(n => source = source.Replace(n, replacements[n]));
            else
            {
                //
                //replacements.Remove("&");
                replacements.Keys.ToList().ForEach(n => source = source.Replace(replacements[n], n));
                source = source.Replace("&amp;", "&");
            }
            return source;
        }

    }
}
