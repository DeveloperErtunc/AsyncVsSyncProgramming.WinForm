namespace AsyncVsSyncProgramming.WinForm;

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
        FileReadBox = new RichTextBox();
        BtnReadFile = new Button();
        BtnCounter = new Button();
        CounterTextBox = new TextBox();
        Clear = new Button();
        button2 = new Button();
        ClearAsync = new Button();
        CountAsyncBox = new TextBox();
        CounterAsync = new Button();
        ReadTextBoxAsync = new RichTextBox();
        ReadAsync = new Button();
        Cities = new RichTextBox();
        Un = new Label();
        SuspendLayout();
        // 
        // FileReadBox
        // 
        FileReadBox.Location = new Point(25, 126);
        FileReadBox.Margin = new Padding(2);
        FileReadBox.Name = "FileReadBox";
        FileReadBox.Size = new Size(289, 99);
        FileReadBox.TabIndex = 1;
        FileReadBox.Text = "";
        // 
        // BtnReadFile
        // 
        BtnReadFile.Font = new Font("Segoe UI", 12F);
        BtnReadFile.Location = new Point(25, 21);
        BtnReadFile.Margin = new Padding(2);
        BtnReadFile.Name = "BtnReadFile";
        BtnReadFile.Size = new Size(288, 37);
        BtnReadFile.TabIndex = 0;
        BtnReadFile.Text = "Read";
        BtnReadFile.UseVisualStyleBackColor = true;
        BtnReadFile.Click += BtnReadFile_Click;
        // 
        // BtnCounter
        // 
        BtnCounter.Font = new Font("Segoe UI", 12F);
        BtnCounter.Location = new Point(645, 21);
        BtnCounter.Margin = new Padding(2);
        BtnCounter.Name = "BtnCounter";
        BtnCounter.Size = new Size(163, 50);
        BtnCounter.TabIndex = 2;
        BtnCounter.Text = "Counter";
        BtnCounter.UseVisualStyleBackColor = true;
        BtnCounter.Click += BtnCounter_Click;
        // 
        // CounterTextBox
        // 
        CounterTextBox.Location = new Point(645, 75);
        CounterTextBox.Margin = new Padding(2);
        CounterTextBox.Name = "CounterTextBox";
        CounterTextBox.Size = new Size(164, 27);
        CounterTextBox.TabIndex = 3;
        // 
        // Clear
        // 
        Clear.Font = new Font("Segoe UI", 12F);
        Clear.Location = new Point(25, 62);
        Clear.Margin = new Padding(2);
        Clear.Name = "Clear";
        Clear.Size = new Size(288, 47);
        Clear.TabIndex = 4;
        Clear.Text = "Clear";
        Clear.UseVisualStyleBackColor = true;
        Clear.Click += Clear_Click;
        // 
        // button2
        // 
        button2.Location = new Point(556, 218);
        button2.Margin = new Padding(2);
        button2.Name = "button2";
        button2.Size = new Size(6, 6);
        button2.TabIndex = 5;
        button2.Text = "button2";
        button2.UseVisualStyleBackColor = true;
        // 
        // ClearAsync
        // 
        ClearAsync.Font = new Font("Segoe UI", 15F);
        ClearAsync.Location = new Point(25, 322);
        ClearAsync.Margin = new Padding(2);
        ClearAsync.Name = "ClearAsync";
        ClearAsync.Size = new Size(288, 46);
        ClearAsync.TabIndex = 10;
        ClearAsync.Text = "Clear Async";
        ClearAsync.UseVisualStyleBackColor = true;
        ClearAsync.Click += ClearAsync_Click;
        // 
        // CountAsyncBox
        // 
        CountAsyncBox.Location = new Point(645, 322);
        CountAsyncBox.Margin = new Padding(2);
        CountAsyncBox.Name = "CountAsyncBox";
        CountAsyncBox.Size = new Size(164, 27);
        CountAsyncBox.TabIndex = 9;
        // 
        // CounterAsync
        // 
        CounterAsync.Font = new Font("Segoe UI", 12F);
        CounterAsync.Location = new Point(645, 259);
        CounterAsync.Margin = new Padding(2);
        CounterAsync.Name = "CounterAsync";
        CounterAsync.Size = new Size(163, 48);
        CounterAsync.TabIndex = 8;
        CounterAsync.Text = "Counter Async";
        CounterAsync.UseVisualStyleBackColor = true;
        CounterAsync.Click += CounterAsync_Click;
        // 
        // ReadTextBoxAsync
        // 
        ReadTextBoxAsync.Location = new Point(25, 389);
        ReadTextBoxAsync.Margin = new Padding(2);
        ReadTextBoxAsync.Name = "ReadTextBoxAsync";
        ReadTextBoxAsync.Size = new Size(289, 99);
        ReadTextBoxAsync.TabIndex = 7;
        ReadTextBoxAsync.Text = "";
        // 
        // ReadAsync
        // 
        ReadAsync.Font = new Font("Segoe UI", 12F);
        ReadAsync.Location = new Point(25, 270);
        ReadAsync.Margin = new Padding(2);
        ReadAsync.Name = "ReadAsync";
        ReadAsync.Size = new Size(288, 48);
        ReadAsync.TabIndex = 6;
        ReadAsync.Text = "Read Async";
        ReadAsync.UseVisualStyleBackColor = true;
        ReadAsync.Click += ReadAsync_Click;
        // 
        // Cities
        // 
        Cities.Location = new Point(25, 560);
        Cities.Name = "Cities";
        Cities.Size = new Size(1153, 402);
        Cities.TabIndex = 11;
        Cities.Text = "";
        // 
        // Un
        // 
        Un.AutoSize = true;
        Un.Font = new Font("Segoe UI", 15F);
        Un.Location = new Point(25, 512);
        Un.Name = "Un";
        Un.Size = new Size(226, 35);
        Un.TabIndex = 12;
        Un.Text = "United States Cities";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1831, 1108);
        Controls.Add(Un);
        Controls.Add(Cities);
        Controls.Add(ClearAsync);
        Controls.Add(CountAsyncBox);
        Controls.Add(CounterAsync);
        Controls.Add(ReadTextBoxAsync);
        Controls.Add(ReadAsync);
        Controls.Add(button2);
        Controls.Add(Clear);
        Controls.Add(CounterTextBox);
        Controls.Add(BtnCounter);
        Controls.Add(FileReadBox);
        Controls.Add(BtnReadFile);
        Margin = new Padding(2);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private RichTextBox FileReadBox;
    private Button BtnReadFile;
    private Button BtnCounter;
    private TextBox CounterTextBox;
    private Button Clear;
    private Button button2;
    private Button ClearAsync;
    private TextBox CountAsyncBox;
    private Button CounterAsync;
    private RichTextBox ReadTextBoxAsync;
    private Button ReadAsync;
    private RichTextBox Cities;
    private Label Un;
}
