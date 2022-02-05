<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Me.txtAddVal1 = New System.Windows.Forms.TextBox()
        Me.txtAddVal2 = New System.Windows.Forms.TextBox()
        Me.lblCalcTitle = New System.Windows.Forms.Label()
        Me.lblPlusEqual = New System.Windows.Forms.Label()
        Me.txtSum = New System.Windows.Forms.TextBox()
        Me.btnAddValues = New System.Windows.Forms.Button()
        Me.btnSubValues = New System.Windows.Forms.Button()
        Me.txtDifference = New System.Windows.Forms.TextBox()
        Me.lblMinusEqual = New System.Windows.Forms.Label()
        Me.txtSubVal2 = New System.Windows.Forms.TextBox()
        Me.txtSubVal1 = New System.Windows.Forms.TextBox()
        Me.btnMulValues = New System.Windows.Forms.Button()
        Me.txtProduct = New System.Windows.Forms.TextBox()
        Me.lblTimesEqual = New System.Windows.Forms.Label()
        Me.txtMulVal2 = New System.Windows.Forms.TextBox()
        Me.txtMulVal1 = New System.Windows.Forms.TextBox()
        Me.btnDivValues = New System.Windows.Forms.Button()
        Me.txtQuotient = New System.Windows.Forms.TextBox()
        Me.lblDivEqual = New System.Windows.Forms.Label()
        Me.txtDivVal2 = New System.Windows.Forms.TextBox()
        Me.txtDivVal1 = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnChangeName = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtAddVal1
        '
        Me.txtAddVal1.Location = New System.Drawing.Point(26, 179)
        Me.txtAddVal1.Name = "txtAddVal1"
        Me.txtAddVal1.Size = New System.Drawing.Size(78, 31)
        Me.txtAddVal1.TabIndex = 0
        '
        'txtAddVal2
        '
        Me.txtAddVal2.Location = New System.Drawing.Point(180, 179)
        Me.txtAddVal2.Name = "txtAddVal2"
        Me.txtAddVal2.Size = New System.Drawing.Size(78, 31)
        Me.txtAddVal2.TabIndex = 1
        '
        'lblCalcTitle
        '
        Me.lblCalcTitle.AutoSize = True
        Me.lblCalcTitle.Location = New System.Drawing.Point(168, 114)
        Me.lblCalcTitle.Name = "lblCalcTitle"
        Me.lblCalcTitle.Size = New System.Drawing.Size(90, 25)
        Me.lblCalcTitle.TabIndex = 2
        Me.lblCalcTitle.Text = "Calculator"
        '
        'lblPlusEqual
        '
        Me.lblPlusEqual.AutoSize = True
        Me.lblPlusEqual.Location = New System.Drawing.Point(284, 179)
        Me.lblPlusEqual.Name = "lblPlusEqual"
        Me.lblPlusEqual.Size = New System.Drawing.Size(24, 25)
        Me.lblPlusEqual.TabIndex = 4
        Me.lblPlusEqual.Text = "="
        '
        'txtSum
        '
        Me.txtSum.Location = New System.Drawing.Point(329, 179)
        Me.txtSum.Name = "txtSum"
        Me.txtSum.Size = New System.Drawing.Size(78, 31)
        Me.txtSum.TabIndex = 5
        '
        'btnAddValues
        '
        Me.btnAddValues.Location = New System.Drawing.Point(122, 179)
        Me.btnAddValues.Name = "btnAddValues"
        Me.btnAddValues.Size = New System.Drawing.Size(38, 34)
        Me.btnAddValues.TabIndex = 6
        Me.btnAddValues.Text = "+"
        Me.btnAddValues.UseVisualStyleBackColor = True
        '
        'btnSubValues
        '
        Me.btnSubValues.Location = New System.Drawing.Point(122, 247)
        Me.btnSubValues.Name = "btnSubValues"
        Me.btnSubValues.Size = New System.Drawing.Size(38, 34)
        Me.btnSubValues.TabIndex = 11
        Me.btnSubValues.Text = "-"
        Me.btnSubValues.UseVisualStyleBackColor = True
        '
        'txtDifference
        '
        Me.txtDifference.Location = New System.Drawing.Point(329, 247)
        Me.txtDifference.Name = "txtDifference"
        Me.txtDifference.Size = New System.Drawing.Size(78, 31)
        Me.txtDifference.TabIndex = 10
        '
        'lblMinusEqual
        '
        Me.lblMinusEqual.AutoSize = True
        Me.lblMinusEqual.Location = New System.Drawing.Point(284, 247)
        Me.lblMinusEqual.Name = "lblMinusEqual"
        Me.lblMinusEqual.Size = New System.Drawing.Size(24, 25)
        Me.lblMinusEqual.TabIndex = 9
        Me.lblMinusEqual.Text = "="
        '
        'txtSubVal2
        '
        Me.txtSubVal2.Location = New System.Drawing.Point(180, 247)
        Me.txtSubVal2.Name = "txtSubVal2"
        Me.txtSubVal2.Size = New System.Drawing.Size(78, 31)
        Me.txtSubVal2.TabIndex = 8
        '
        'txtSubVal1
        '
        Me.txtSubVal1.Location = New System.Drawing.Point(26, 247)
        Me.txtSubVal1.Name = "txtSubVal1"
        Me.txtSubVal1.Size = New System.Drawing.Size(78, 31)
        Me.txtSubVal1.TabIndex = 7
        '
        'btnMulValues
        '
        Me.btnMulValues.Location = New System.Drawing.Point(122, 316)
        Me.btnMulValues.Name = "btnMulValues"
        Me.btnMulValues.Size = New System.Drawing.Size(38, 34)
        Me.btnMulValues.TabIndex = 16
        Me.btnMulValues.Text = "x"
        Me.btnMulValues.UseVisualStyleBackColor = True
        '
        'txtProduct
        '
        Me.txtProduct.Location = New System.Drawing.Point(329, 316)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Size = New System.Drawing.Size(78, 31)
        Me.txtProduct.TabIndex = 15
        '
        'lblTimesEqual
        '
        Me.lblTimesEqual.AutoSize = True
        Me.lblTimesEqual.Location = New System.Drawing.Point(284, 316)
        Me.lblTimesEqual.Name = "lblTimesEqual"
        Me.lblTimesEqual.Size = New System.Drawing.Size(24, 25)
        Me.lblTimesEqual.TabIndex = 14
        Me.lblTimesEqual.Text = "="
        '
        'txtMulVal2
        '
        Me.txtMulVal2.Location = New System.Drawing.Point(180, 316)
        Me.txtMulVal2.Name = "txtMulVal2"
        Me.txtMulVal2.Size = New System.Drawing.Size(78, 31)
        Me.txtMulVal2.TabIndex = 13
        '
        'txtMulVal1
        '
        Me.txtMulVal1.Location = New System.Drawing.Point(26, 316)
        Me.txtMulVal1.Name = "txtMulVal1"
        Me.txtMulVal1.Size = New System.Drawing.Size(78, 31)
        Me.txtMulVal1.TabIndex = 12
        '
        'btnDivValues
        '
        Me.btnDivValues.Location = New System.Drawing.Point(122, 381)
        Me.btnDivValues.Name = "btnDivValues"
        Me.btnDivValues.Size = New System.Drawing.Size(38, 34)
        Me.btnDivValues.TabIndex = 21
        Me.btnDivValues.Text = "/"
        Me.btnDivValues.UseVisualStyleBackColor = True
        '
        'txtQuotient
        '
        Me.txtQuotient.Location = New System.Drawing.Point(329, 381)
        Me.txtQuotient.Name = "txtQuotient"
        Me.txtQuotient.Size = New System.Drawing.Size(78, 31)
        Me.txtQuotient.TabIndex = 20
        '
        'lblDivEqual
        '
        Me.lblDivEqual.AutoSize = True
        Me.lblDivEqual.Location = New System.Drawing.Point(284, 381)
        Me.lblDivEqual.Name = "lblDivEqual"
        Me.lblDivEqual.Size = New System.Drawing.Size(24, 25)
        Me.lblDivEqual.TabIndex = 19
        Me.lblDivEqual.Text = "="
        '
        'txtDivVal2
        '
        Me.txtDivVal2.Location = New System.Drawing.Point(180, 381)
        Me.txtDivVal2.Name = "txtDivVal2"
        Me.txtDivVal2.Size = New System.Drawing.Size(78, 31)
        Me.txtDivVal2.TabIndex = 18
        '
        'txtDivVal1
        '
        Me.txtDivVal1.Location = New System.Drawing.Point(26, 381)
        Me.txtDivVal1.Name = "txtDivVal1"
        Me.txtDivVal1.Size = New System.Drawing.Size(78, 31)
        Me.txtDivVal1.TabIndex = 17
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(12, 54)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(121, 31)
        Me.txtUserName.TabIndex = 23
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(63, 25)
        Me.lblName.TabIndex = 24
        Me.lblName.Text = "Name:"
        '
        'btnChangeName
        '
        Me.btnChangeName.Location = New System.Drawing.Point(152, 49)
        Me.btnChangeName.Name = "btnChangeName"
        Me.btnChangeName.Size = New System.Drawing.Size(54, 40)
        Me.btnChangeName.TabIndex = 25
        Me.btnChangeName.Text = "&Ok"
        Me.btnChangeName.UseVisualStyleBackColor = True
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 479)
        Me.Controls.Add(Me.btnChangeName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.btnDivValues)
        Me.Controls.Add(Me.txtQuotient)
        Me.Controls.Add(Me.lblDivEqual)
        Me.Controls.Add(Me.txtDivVal2)
        Me.Controls.Add(Me.txtDivVal1)
        Me.Controls.Add(Me.btnMulValues)
        Me.Controls.Add(Me.txtProduct)
        Me.Controls.Add(Me.lblTimesEqual)
        Me.Controls.Add(Me.txtMulVal2)
        Me.Controls.Add(Me.txtMulVal1)
        Me.Controls.Add(Me.btnSubValues)
        Me.Controls.Add(Me.txtDifference)
        Me.Controls.Add(Me.lblMinusEqual)
        Me.Controls.Add(Me.txtSubVal2)
        Me.Controls.Add(Me.txtSubVal1)
        Me.Controls.Add(Me.btnAddValues)
        Me.Controls.Add(Me.txtSum)
        Me.Controls.Add(Me.lblPlusEqual)
        Me.Controls.Add(Me.lblCalcTitle)
        Me.Controls.Add(Me.txtAddVal2)
        Me.Controls.Add(Me.txtAddVal1)
        Me.Name = "Calculator"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAddVal1 As TextBox
    Friend WithEvents txtAddVal2 As TextBox
    Friend WithEvents lblCalcTitle As Label
    Friend WithEvents lblPlusEqual As Label
    Friend WithEvents txtSum As TextBox
    Friend WithEvents btnAddValues As Button
    Friend WithEvents btnSubValues As Button
    Friend WithEvents txtDifference As TextBox
    Friend WithEvents lblMinusEqual As Label
    Friend WithEvents txtSubVal2 As TextBox
    Friend WithEvents txtSubVal1 As TextBox
    Friend WithEvents btnMulValues As Button
    Friend WithEvents txtProduct As TextBox
    Friend WithEvents lblTimesEqual As Label
    Friend WithEvents txtMulVal2 As TextBox
    Friend WithEvents txtMulVal1 As TextBox
    Friend WithEvents btnDivValues As Button
    Friend WithEvents txtQuotient As TextBox
    Friend WithEvents lblDivEqual As Label
    Friend WithEvents txtDivVal2 As TextBox
    Friend WithEvents txtDivVal1 As TextBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents btnChangeName As Button
End Class
