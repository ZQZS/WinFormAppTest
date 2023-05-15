namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonCheck = new Button();
            txtUserName = new TextBox();
            btnChange = new Button();
            btnGoHome = new Button();
            btnFunction = new Button();
            btnRef = new Button();
            btnParam = new Button();
            btnClassTest = new Button();
            btnInherit = new Button();
            btnInterfaces = new Button();
            btnInterface2 = new Button();
            label1 = new Label();
            btnValueType = new Button();
            btnArrayList = new Button();
            btnList = new Button();
            btnListShow = new Button();
            btnDictionary = new Button();
            btnExpendFunc = new Button();
            SuspendLayout();
            // 
            // buttonCheck
            // 
            buttonCheck.Location = new Point(12, 86);
            buttonCheck.Name = "buttonCheck";
            buttonCheck.Size = new Size(125, 34);
            buttonCheck.TabIndex = 0;
            buttonCheck.Text = "button1";
            buttonCheck.UseVisualStyleBackColor = true;
            buttonCheck.Click += buttonCheck_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(12, 22);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(125, 27);
            txtUserName.TabIndex = 1;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(12, 161);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(125, 38);
            btnChange.TabIndex = 2;
            btnChange.Text = "转换";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // btnGoHome
            // 
            btnGoHome.Location = new Point(13, 245);
            btnGoHome.Name = "btnGoHome";
            btnGoHome.Size = new Size(124, 45);
            btnGoHome.TabIndex = 3;
            btnGoHome.Text = "送回家";
            btnGoHome.UseVisualStyleBackColor = true;
            btnGoHome.Click += btnGoHome_Click;
            // 
            // btnFunction
            // 
            btnFunction.Location = new Point(274, 16);
            btnFunction.Name = "btnFunction";
            btnFunction.Size = new Size(115, 38);
            btnFunction.TabIndex = 4;
            btnFunction.Text = "function测试";
            btnFunction.UseVisualStyleBackColor = true;
            btnFunction.Click += button1_Click;
            // 
            // btnRef
            // 
            btnRef.Location = new Point(274, 86);
            btnRef.Name = "btnRef";
            btnRef.Size = new Size(94, 29);
            btnRef.TabIndex = 5;
            btnRef.Text = "ref测试";
            btnRef.UseVisualStyleBackColor = true;
            btnRef.Click += btnRef_Click;
            // 
            // btnParam
            // 
            btnParam.Location = new Point(272, 168);
            btnParam.Name = "btnParam";
            btnParam.Size = new Size(94, 29);
            btnParam.TabIndex = 6;
            btnParam.Text = "param测试";
            btnParam.UseVisualStyleBackColor = true;
            btnParam.Click += btnParam_Click;
            // 
            // btnClassTest
            // 
            btnClassTest.Location = new Point(280, 248);
            btnClassTest.Name = "btnClassTest";
            btnClassTest.Size = new Size(109, 33);
            btnClassTest.TabIndex = 7;
            btnClassTest.Text = "Class测试";
            btnClassTest.UseVisualStyleBackColor = true;
            btnClassTest.Click += btnClassTest_Click;
            // 
            // btnInherit
            // 
            btnInherit.Location = new Point(280, 326);
            btnInherit.Name = "btnInherit";
            btnInherit.Size = new Size(94, 29);
            btnInherit.TabIndex = 8;
            btnInherit.Text = "继承";
            btnInherit.UseVisualStyleBackColor = true;
            btnInherit.Click += btnInherit_Click;
            // 
            // btnInterfaces
            // 
            btnInterfaces.Location = new Point(466, 11);
            btnInterfaces.Name = "btnInterfaces";
            btnInterfaces.Size = new Size(131, 38);
            btnInterfaces.TabIndex = 9;
            btnInterfaces.Text = "接口";
            btnInterfaces.UseVisualStyleBackColor = true;
            btnInterfaces.Click += btnInterfaces_Click;
            // 
            // btnInterface2
            // 
            btnInterface2.Location = new Point(464, 83);
            btnInterface2.Name = "btnInterface2";
            btnInterface2.Size = new Size(94, 29);
            btnInterface2.TabIndex = 10;
            btnInterface2.Text = "多态";
            btnInterface2.UseVisualStyleBackColor = true;
            btnInterface2.Click += btnInterface2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(476, 164);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 11;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // btnValueType
            // 
            btnValueType.Location = new Point(466, 227);
            btnValueType.Name = "btnValueType";
            btnValueType.Size = new Size(107, 44);
            btnValueType.TabIndex = 12;
            btnValueType.Text = "值类型";
            btnValueType.UseVisualStyleBackColor = true;
            btnValueType.Click += btnValueType_Click;
            // 
            // btnArrayList
            // 
            btnArrayList.Location = new Point(467, 322);
            btnArrayList.Name = "btnArrayList";
            btnArrayList.Size = new Size(102, 31);
            btnArrayList.TabIndex = 13;
            btnArrayList.Text = "ArrayList";
            btnArrayList.UseVisualStyleBackColor = true;
            btnArrayList.Click += btnArrayList_Click;
            // 
            // btnList
            // 
            btnList.Location = new Point(665, 15);
            btnList.Name = "btnList";
            btnList.Size = new Size(135, 41);
            btnList.TabIndex = 14;
            btnList.Text = "List";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // btnListShow
            // 
            btnListShow.Location = new Point(666, 86);
            btnListShow.Name = "btnListShow";
            btnListShow.Size = new Size(134, 40);
            btnListShow.TabIndex = 15;
            btnListShow.Text = "ListWindowShow";
            btnListShow.UseVisualStyleBackColor = true;
            btnListShow.Click += btnListShow_Click;
            // 
            // btnDictionary
            // 
            btnDictionary.Location = new Point(662, 164);
            btnDictionary.Name = "btnDictionary";
            btnDictionary.Size = new Size(149, 43);
            btnDictionary.TabIndex = 16;
            btnDictionary.Text = "dictionary";
            btnDictionary.UseVisualStyleBackColor = true;
            btnDictionary.Click += btnDictionary_Click;
            // 
            // btnExpendFunc
            // 
            btnExpendFunc.Location = new Point(656, 237);
            btnExpendFunc.Name = "btnExpendFunc";
            btnExpendFunc.Size = new Size(148, 42);
            btnExpendFunc.TabIndex = 17;
            btnExpendFunc.Text = "扩展方法";
            btnExpendFunc.UseVisualStyleBackColor = true;
            btnExpendFunc.Click += btnExpendFunc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 505);
            Controls.Add(btnExpendFunc);
            Controls.Add(btnDictionary);
            Controls.Add(btnListShow);
            Controls.Add(btnList);
            Controls.Add(btnArrayList);
            Controls.Add(btnValueType);
            Controls.Add(label1);
            Controls.Add(btnInterface2);
            Controls.Add(btnInterfaces);
            Controls.Add(btnInherit);
            Controls.Add(btnClassTest);
            Controls.Add(btnParam);
            Controls.Add(btnRef);
            Controls.Add(btnFunction);
            Controls.Add(btnGoHome);
            Controls.Add(btnChange);
            Controls.Add(txtUserName);
            Controls.Add(buttonCheck);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCheck;
        private TextBox txtUserName;
        private Button btnChange;
        private Button btnGoHome;
        private Button btnFunction;
        private Button btnRef;
        private Button btnParam;
        private Button btnClassTest;
        private Button btnInherit;
        private Button btnInterfaces;
        private Button btnInterface2;
        private Label label1;
        private Button btnValueType;
        private Button btnArrayList;
        private Button btnList;
        private Button btnListShow;
        private Button btnDictionary;
        private Button btnExpendFunc;
    }
}