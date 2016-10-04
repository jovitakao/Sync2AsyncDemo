namespace Sync2AsyncDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblResult = new System.Windows.Forms.Label();
            this.demo1 = new System.Windows.Forms.Button();
            this.demo2 = new System.Windows.Forms.Button();
            this.demo3 = new System.Windows.Forms.Button();
            this.demo4 = new System.Windows.Forms.Button();
            this.demo5 = new System.Windows.Forms.Button();
            this.demo6 = new System.Windows.Forms.Button();
            this.demo7 = new System.Windows.Forms.Button();
            this.demo8 = new System.Windows.Forms.Button();
            this.demo9 = new System.Windows.Forms.Button();
            this.demo10 = new System.Windows.Forms.Button();
            this.demo11 = new System.Windows.Forms.Button();
            this.demo12 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblResult.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(0, 0);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(68, 29);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Result";
            // 
            // demo1
            // 
            this.demo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.demo1.Location = new System.Drawing.Point(0, 29);
            this.demo1.Name = "demo1";
            this.demo1.Size = new System.Drawing.Size(1016, 43);
            this.demo1.TabIndex = 1;
            this.demo1.Text = "1.Block UI";
            this.demo1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.demo1.UseVisualStyleBackColor = true;
            this.demo1.Click += new System.EventHandler(this.demo1_Click);
            // 
            // demo2
            // 
            this.demo2.Dock = System.Windows.Forms.DockStyle.Top;
            this.demo2.Location = new System.Drawing.Point(0, 72);
            this.demo2.Name = "demo2";
            this.demo2.Size = new System.Drawing.Size(1016, 41);
            this.demo2.TabIndex = 2;
            this.demo2.Text = "2.Block UI wait task result";
            this.demo2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.demo2.UseVisualStyleBackColor = true;
            this.demo2.Click += new System.EventHandler(this.demo2_Click);
            // 
            // demo3
            // 
            this.demo3.Dock = System.Windows.Forms.DockStyle.Top;
            this.demo3.Location = new System.Drawing.Point(0, 113);
            this.demo3.Name = "demo3";
            this.demo3.Size = new System.Drawing.Size(1016, 41);
            this.demo3.TabIndex = 3;
            this.demo3.Text = "3.Non Block UI, but can\'t update UI";
            this.demo3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.demo3.UseVisualStyleBackColor = true;
            this.demo3.Click += new System.EventHandler(this.demo3_Click);
            // 
            // demo4
            // 
            this.demo4.Dock = System.Windows.Forms.DockStyle.Top;
            this.demo4.Location = new System.Drawing.Point(0, 154);
            this.demo4.Name = "demo4";
            this.demo4.Size = new System.Drawing.Size(1016, 41);
            this.demo4.TabIndex = 4;
            this.demo4.Text = "4.Non block UI, with exception";
            this.demo4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.demo4.UseVisualStyleBackColor = true;
            this.demo4.Click += new System.EventHandler(this.demo4_Click);
            // 
            // demo5
            // 
            this.demo5.Dock = System.Windows.Forms.DockStyle.Top;
            this.demo5.Location = new System.Drawing.Point(0, 195);
            this.demo5.Name = "demo5";
            this.demo5.Size = new System.Drawing.Size(1016, 41);
            this.demo5.TabIndex = 5;
            this.demo5.Text = "5.Non block UI, with exception handle";
            this.demo5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.demo5.UseVisualStyleBackColor = true;
            this.demo5.Click += new System.EventHandler(this.demo5_Click);
            // 
            // demo6
            // 
            this.demo6.Dock = System.Windows.Forms.DockStyle.Top;
            this.demo6.Location = new System.Drawing.Point(0, 236);
            this.demo6.Name = "demo6";
            this.demo6.Size = new System.Drawing.Size(1016, 41);
            this.demo6.TabIndex = 6;
            this.demo6.Text = "6.Non block ui , Update UI at main thread";
            this.demo6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.demo6.UseVisualStyleBackColor = true;
            this.demo6.Click += new System.EventHandler(this.demo6_Click);
            // 
            // demo7
            // 
            this.demo7.Dock = System.Windows.Forms.DockStyle.Top;
            this.demo7.Location = new System.Drawing.Point(0, 277);
            this.demo7.Name = "demo7";
            this.demo7.Size = new System.Drawing.Size(1016, 41);
            this.demo7.TabIndex = 7;
            this.demo7.Text = "7.Non block ui ,using async await";
            this.demo7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.demo7.UseVisualStyleBackColor = true;
            this.demo7.Click += new System.EventHandler(this.demo7_Click);
            // 
            // demo8
            // 
            this.demo8.Dock = System.Windows.Forms.DockStyle.Top;
            this.demo8.Location = new System.Drawing.Point(0, 318);
            this.demo8.Name = "demo8";
            this.demo8.Size = new System.Drawing.Size(1016, 41);
            this.demo8.TabIndex = 8;
            this.demo8.Text = "8.Non block ui ,async await with Exception ";
            this.demo8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.demo8.UseVisualStyleBackColor = true;
            this.demo8.Click += new System.EventHandler(this.demo8_Click);
            // 
            // demo9
            // 
            this.demo9.Dock = System.Windows.Forms.DockStyle.Top;
            this.demo9.Location = new System.Drawing.Point(0, 359);
            this.demo9.Name = "demo9";
            this.demo9.Size = new System.Drawing.Size(1016, 41);
            this.demo9.TabIndex = 9;
            this.demo9.Text = "9.call async await  Exception fun with try...catch";
            this.demo9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.demo9.UseVisualStyleBackColor = true;
            this.demo9.Click += new System.EventHandler(this.demo9_Click);
            // 
            // demo10
            // 
            this.demo10.Dock = System.Windows.Forms.DockStyle.Top;
            this.demo10.Location = new System.Drawing.Point(0, 400);
            this.demo10.Name = "demo10";
            this.demo10.Size = new System.Drawing.Size(1016, 41);
            this.demo10.TabIndex = 10;
            this.demo10.Text = "10.call async await fun Exception  with try...catch & return task";
            this.demo10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.demo10.UseVisualStyleBackColor = true;
            this.demo10.Click += new System.EventHandler(this.demo10_Click);
            // 
            // demo11
            // 
            this.demo11.Dock = System.Windows.Forms.DockStyle.Top;
            this.demo11.Location = new System.Drawing.Point(0, 441);
            this.demo11.Name = "demo11";
            this.demo11.Size = new System.Drawing.Size(1016, 41);
            this.demo11.TabIndex = 11;
            this.demo11.Text = "11.call async await fun  Exception  with try.. await ...catch & return task ";
            this.demo11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.demo11.UseVisualStyleBackColor = true;
            this.demo11.Click += new System.EventHandler(this.demo11_Click);
            // 
            // demo12
            // 
            this.demo12.Dock = System.Windows.Forms.DockStyle.Top;
            this.demo12.Location = new System.Drawing.Point(0, 482);
            this.demo12.Name = "demo12";
            this.demo12.Size = new System.Drawing.Size(1016, 41);
            this.demo12.TabIndex = 12;
            this.demo12.Text = "12.Deadlock task";
            this.demo12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.demo12.UseVisualStyleBackColor = true;
            this.demo12.Click += new System.EventHandler(this.demo12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 627);
            this.Controls.Add(this.demo12);
            this.Controls.Add(this.demo11);
            this.Controls.Add(this.demo10);
            this.Controls.Add(this.demo9);
            this.Controls.Add(this.demo8);
            this.Controls.Add(this.demo7);
            this.Controls.Add(this.demo6);
            this.Controls.Add(this.demo5);
            this.Controls.Add(this.demo4);
            this.Controls.Add(this.demo3);
            this.Controls.Add(this.demo2);
            this.Controls.Add(this.demo1);
            this.Controls.Add(this.lblResult);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Sync to Async Test Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button demo1;
        private System.Windows.Forms.Button demo2;
        private System.Windows.Forms.Button demo3;
        private System.Windows.Forms.Button demo4;
        private System.Windows.Forms.Button demo5;
        private System.Windows.Forms.Button demo6;
        private System.Windows.Forms.Button demo7;
        private System.Windows.Forms.Button demo8;
        private System.Windows.Forms.Button demo9;
        private System.Windows.Forms.Button demo10;
        private System.Windows.Forms.Button demo11;
        private System.Windows.Forms.Button demo12;
    }
}

