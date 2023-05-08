<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.picJar = New System.Windows.Forms.PictureBox()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.btnTipYes = New System.Windows.Forms.Button()
        Me.btnTipNo = New System.Windows.Forms.Button()
        Me.grpbxOptions = New System.Windows.Forms.GroupBox()
        Me.txtCustomTip = New System.Windows.Forms.TextBox()
        Me.rbtnCustom = New System.Windows.Forms.RadioButton()
        Me.rbtn25 = New System.Windows.Forms.RadioButton()
        Me.rbtn20 = New System.Windows.Forms.RadioButton()
        Me.rbtn15 = New System.Windows.Forms.RadioButton()
        Me.lblBill = New System.Windows.Forms.Label()
        Me.txtBill = New System.Windows.Forms.TextBox()
        Me.lblTipAmount = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        CType(Me.picJar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbxOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'picJar
        '
        Me.picJar.Image = CType(resources.GetObject("picJar.Image"), System.Drawing.Image)
        Me.picJar.Location = New System.Drawing.Point(24, 59)
        Me.picJar.Name = "picJar"
        Me.picJar.Size = New System.Drawing.Size(242, 243)
        Me.picJar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picJar.TabIndex = 0
        Me.picJar.TabStop = False
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.BackColor = System.Drawing.Color.Transparent
        Me.lblPrompt.Font = New System.Drawing.Font("DM Sans", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrompt.ForeColor = System.Drawing.Color.SlateBlue
        Me.lblPrompt.Location = New System.Drawing.Point(399, 36)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(230, 48)
        Me.lblPrompt.TabIndex = 1
        Me.lblPrompt.Text = "Leave a tip?"
        '
        'btnTipYes
        '
        Me.btnTipYes.BackColor = System.Drawing.Color.SlateBlue
        Me.btnTipYes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTipYes.Font = New System.Drawing.Font("DM Sans", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTipYes.ForeColor = System.Drawing.Color.White
        Me.btnTipYes.Location = New System.Drawing.Point(339, 109)
        Me.btnTipYes.Name = "btnTipYes"
        Me.btnTipYes.Size = New System.Drawing.Size(135, 37)
        Me.btnTipYes.TabIndex = 2
        Me.btnTipYes.Text = "Yes"
        Me.btnTipYes.UseVisualStyleBackColor = False
        '
        'btnTipNo
        '
        Me.btnTipNo.BackColor = System.Drawing.Color.SlateBlue
        Me.btnTipNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTipNo.Font = New System.Drawing.Font("DM Sans", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTipNo.ForeColor = System.Drawing.Color.White
        Me.btnTipNo.Location = New System.Drawing.Point(556, 109)
        Me.btnTipNo.Name = "btnTipNo"
        Me.btnTipNo.Size = New System.Drawing.Size(135, 37)
        Me.btnTipNo.TabIndex = 3
        Me.btnTipNo.Text = "No"
        Me.btnTipNo.UseVisualStyleBackColor = False
        '
        'grpbxOptions
        '
        Me.grpbxOptions.BackColor = System.Drawing.Color.Transparent
        Me.grpbxOptions.Controls.Add(Me.txtCustomTip)
        Me.grpbxOptions.Controls.Add(Me.rbtnCustom)
        Me.grpbxOptions.Controls.Add(Me.rbtn25)
        Me.grpbxOptions.Controls.Add(Me.rbtn20)
        Me.grpbxOptions.Controls.Add(Me.rbtn15)
        Me.grpbxOptions.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpbxOptions.Location = New System.Drawing.Point(301, 87)
        Me.grpbxOptions.Name = "grpbxOptions"
        Me.grpbxOptions.Size = New System.Drawing.Size(423, 178)
        Me.grpbxOptions.TabIndex = 4
        Me.grpbxOptions.TabStop = False
        Me.grpbxOptions.Visible = False
        '
        'txtCustomTip
        '
        Me.txtCustomTip.Font = New System.Drawing.Font("DM Sans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomTip.ForeColor = System.Drawing.Color.SlateBlue
        Me.txtCustomTip.Location = New System.Drawing.Point(138, 133)
        Me.txtCustomTip.Name = "txtCustomTip"
        Me.txtCustomTip.Size = New System.Drawing.Size(59, 35)
        Me.txtCustomTip.TabIndex = 4
        Me.txtCustomTip.Text = "0.00"
        '
        'rbtnCustom
        '
        Me.rbtnCustom.AutoSize = True
        Me.rbtnCustom.BackColor = System.Drawing.Color.Transparent
        Me.rbtnCustom.Font = New System.Drawing.Font("DM Sans", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnCustom.ForeColor = System.Drawing.Color.SlateBlue
        Me.rbtnCustom.Location = New System.Drawing.Point(7, 133)
        Me.rbtnCustom.Name = "rbtnCustom"
        Me.rbtnCustom.Size = New System.Drawing.Size(125, 35)
        Me.rbtnCustom.TabIndex = 3
        Me.rbtnCustom.TabStop = True
        Me.rbtnCustom.Text = "Custom"
        Me.rbtnCustom.UseVisualStyleBackColor = False
        '
        'rbtn25
        '
        Me.rbtn25.AutoSize = True
        Me.rbtn25.Font = New System.Drawing.Font("DM Sans", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn25.ForeColor = System.Drawing.Color.SlateBlue
        Me.rbtn25.Location = New System.Drawing.Point(7, 95)
        Me.rbtn25.Name = "rbtn25"
        Me.rbtn25.Size = New System.Drawing.Size(82, 35)
        Me.rbtn25.TabIndex = 2
        Me.rbtn25.TabStop = True
        Me.rbtn25.Text = "25%"
        Me.rbtn25.UseVisualStyleBackColor = True
        '
        'rbtn20
        '
        Me.rbtn20.AutoSize = True
        Me.rbtn20.Font = New System.Drawing.Font("DM Sans", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn20.ForeColor = System.Drawing.Color.SlateBlue
        Me.rbtn20.Location = New System.Drawing.Point(6, 57)
        Me.rbtn20.Name = "rbtn20"
        Me.rbtn20.Size = New System.Drawing.Size(84, 35)
        Me.rbtn20.TabIndex = 1
        Me.rbtn20.TabStop = True
        Me.rbtn20.Text = "20%"
        Me.rbtn20.UseVisualStyleBackColor = True
        '
        'rbtn15
        '
        Me.rbtn15.AutoSize = True
        Me.rbtn15.Checked = True
        Me.rbtn15.Font = New System.Drawing.Font("DM Sans", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn15.ForeColor = System.Drawing.Color.SlateBlue
        Me.rbtn15.Location = New System.Drawing.Point(6, 19)
        Me.rbtn15.Name = "rbtn15"
        Me.rbtn15.Size = New System.Drawing.Size(76, 35)
        Me.rbtn15.TabIndex = 0
        Me.rbtn15.TabStop = True
        Me.rbtn15.Text = "15%"
        Me.rbtn15.UseVisualStyleBackColor = True
        '
        'lblBill
        '
        Me.lblBill.AutoSize = True
        Me.lblBill.BackColor = System.Drawing.Color.Transparent
        Me.lblBill.Font = New System.Drawing.Font("DM Sans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBill.ForeColor = System.Drawing.Color.SlateBlue
        Me.lblBill.Location = New System.Drawing.Point(296, 274)
        Me.lblBill.Name = "lblBill"
        Me.lblBill.Size = New System.Drawing.Size(194, 28)
        Me.lblBill.TabIndex = 5
        Me.lblBill.Text = "Enter Bill Amount:"
        Me.lblBill.Visible = False
        '
        'txtBill
        '
        Me.txtBill.BackColor = System.Drawing.Color.White
        Me.txtBill.Font = New System.Drawing.Font("DM Sans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBill.ForeColor = System.Drawing.Color.SlateBlue
        Me.txtBill.Location = New System.Drawing.Point(490, 271)
        Me.txtBill.Name = "txtBill"
        Me.txtBill.Size = New System.Drawing.Size(100, 35)
        Me.txtBill.TabIndex = 6
        Me.txtBill.Visible = False
        '
        'lblTipAmount
        '
        Me.lblTipAmount.AutoSize = True
        Me.lblTipAmount.Font = New System.Drawing.Font("DM Sans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipAmount.ForeColor = System.Drawing.Color.SlateBlue
        Me.lblTipAmount.Location = New System.Drawing.Point(296, 374)
        Me.lblTipAmount.Name = "lblTipAmount"
        Me.lblTipAmount.Size = New System.Drawing.Size(142, 28)
        Me.lblTipAmount.TabIndex = 7
        Me.lblTipAmount.Text = "Tip Amount: "
        Me.lblTipAmount.Visible = False
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("DM Sans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.ForeColor = System.Drawing.Color.SlateBlue
        Me.lblTotalCost.Location = New System.Drawing.Point(296, 402)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(124, 28)
        Me.lblTotalCost.TabIndex = 8
        Me.lblTotalCost.Text = "Total Cost: "
        Me.lblTotalCost.Visible = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.SlateBlue
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalculate.Font = New System.Drawing.Font("DM Sans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.White
        Me.btnCalculate.Location = New System.Drawing.Point(378, 321)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(191, 33)
        Me.btnCalculate.TabIndex = 9
        Me.btnCalculate.Text = "Calculate Tip"
        Me.btnCalculate.UseVisualStyleBackColor = False
        Me.btnCalculate.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblTipAmount)
        Me.Controls.Add(Me.txtBill)
        Me.Controls.Add(Me.lblBill)
        Me.Controls.Add(Me.grpbxOptions)
        Me.Controls.Add(Me.btnTipNo)
        Me.Controls.Add(Me.btnTipYes)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.picJar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Tip Jar"
        CType(Me.picJar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbxOptions.ResumeLayout(False)
        Me.grpbxOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picJar As PictureBox
    Friend WithEvents lblPrompt As Label
    Friend WithEvents btnTipYes As Button
    Friend WithEvents btnTipNo As Button
    Friend WithEvents grpbxOptions As GroupBox
    Friend WithEvents rbtnCustom As RadioButton
    Friend WithEvents rbtn25 As RadioButton
    Friend WithEvents rbtn20 As RadioButton
    Friend WithEvents rbtn15 As RadioButton
    Friend WithEvents lblBill As Label
    Friend WithEvents txtBill As TextBox
    Friend WithEvents lblTipAmount As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtCustomTip As TextBox
End Class
