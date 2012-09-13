using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FF.Analysis.Core.Docx;

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;

using FF.Analysis.Core.Extensions;

namespace WebApplication1
{
    public partial class _Default : System.Web.UI.Page
    {
        /// <summary>
        /// Sample App Page Load 
        /// </summary>
        /// <document>
        ///     
        /// </document>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!this.IsPostBack)
            {
                Test1 obj = new Test1() { ID = "A1", Name = "N1" };

                obj.T2 = new Test2() { AA = "A1", BB = "B1", CC=@"Hello World
HHHHHH
BBBB
MMMMM
" };

                obj.TList = new List<Test2>() { new Test2() { AA = "A1", BB = "B1", T3=new Test3(){ T1="T1",T2="T2"} }
                ,new Test2() { AA = "A1", BB = "B1" },new Test2() { AA = "A1", BB = "B1" },new Test2() { AA = "A1", BB = "B1" }};

                string path="d:\\temp\\aa.yaml";

                //obj.SerializeAsYamlToFile(path);
                              
                //Test1 t =path.DeserializeYamlFromPath<Test1>();

                //string cc = t.ID;

            }
        }
    }

    public class Test1
    {
        public string ID { get; set; }

        public string Name { get; set; }

        public Test2 T2 { get; set; }

        public List<Test2> TList { get; set; }
    }

    public class Test2
    {
        public string AA { get; set; }

        public string BB { get; set; }

        public string CC { get; set; }

        public Test3 T3 { get; set; }
    }

    public class Test3
    {
        public string T1 { get; set; }

        public string T2 { get; set; }
    }
}
