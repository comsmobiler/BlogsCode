using Smobiler.Core;

namespace BlogsCode_SmobilerForm
{
    partial class SmobilerForm1 : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm Designer generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm Designer
        //It can be modified using the SmobilerForm Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.btnShowForm2 = new Smobiler.Core.Controls.Button();
            this.labTitle = new Smobiler.Core.Controls.Label();
            // 
            // btnShowForm2
            // 
            this.btnShowForm2.Location = new System.Drawing.Point(73, 79);
            this.btnShowForm2.Name = "btnShowForm2";
            this.btnShowForm2.Size = new System.Drawing.Size(148, 37);
            this.btnShowForm2.Text = "打开SmobilerForm2";
            this.btnShowForm2.Press += new System.EventHandler(this.btnShowForm2_Press);
            // 
            // labTitle
            // 
            this.labTitle.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(300, 35);
            this.labTitle.Text = "SmobilerForm1";
            // 
            // SmobilerForm1
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnShowForm2,
            this.labTitle});
            this.Name = "SmobilerForm1";

        }
        #endregion

        private Smobiler.Core.Controls.Button btnShowForm2;
        private Smobiler.Core.Controls.Label labTitle;
    }
}