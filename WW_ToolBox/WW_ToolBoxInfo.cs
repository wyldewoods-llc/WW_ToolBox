using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace WW_ToolBox
{
    public class WW_ToolBoxInfo : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "WW_ToolBox";
            }
        }
        public override Bitmap Icon
        {
            get
            {
                //Return a 24x24 pixel bitmap to represent this GHA library.
                return null;
            }
        }
        public override string Description
        {
            get
            {
                //Return a short string describing the purpose of this GHA library.
                return "";
            }
        }
        public override Guid Id
        {
            get
            {
                return new Guid("4e87d300-2528-4d52-b620-37446841f7b3");
            }
        }

        public override string AuthorName
        {
            get
            {
                //Return a string identifying you or your company.
                return "";
            }
        }
        public override string AuthorContact
        {
            get
            {
                //Return a string representing your preferred contact details.
                return "";
            }
        }
    }
}
