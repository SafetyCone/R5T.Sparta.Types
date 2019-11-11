using System;

using R5T.Stagira;


namespace R5T.Sparta
{
    public class FileName : TypedString
    {
        #region Static

        public static FileName New(string fileName)
        {
            var output = new FileName(fileName);
            return output;
        }

        #endregion


        public FileName(string value)
            : base(value)
        {
        }
    }
}
