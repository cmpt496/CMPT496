﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagementOption
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
        Me.employeeLabel4 = New System.Windows.Forms.Label()
        Me.UnitLabel1 = New System.Windows.Forms.Label()
        Me.Parkinglable = New System.Windows.Forms.Label()
        Me.Leaselable = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'employeeLabel4
        '
        Me.employeeLabel4.AutoSize = True
        Me.employeeLabel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.employeeLabel4.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.employeeLabel4.ForeColor = System.Drawing.Color.White
        Me.employeeLabel4.Location = New System.Drawing.Point(597, 359)
        Me.employeeLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.employeeLabel4.Name = "employeeLabel4"
        Me.employeeLabel4.Size = New System.Drawing.Size(168, 41)
        Me.employeeLabel4.TabIndex = 11
        Me.employeeLabel4.Text = "Employee"
        '
        'UnitLabel1
        '
        Me.UnitLabel1.AutoSize = True
        Me.UnitLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UnitLabel1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UnitLabel1.ForeColor = System.Drawing.Color.White
        Me.UnitLabel1.Location = New System.Drawing.Point(369, 359)
        Me.UnitLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.UnitLabel1.Name = "UnitLabel1"
        Me.UnitLabel1.Size = New System.Drawing.Size(83, 41)
        Me.UnitLabel1.TabIndex = 12
        Me.UnitLabel1.Text = "Unit"
        '
        'Parkinglable
        '
        Me.Parkinglable.AutoSize = True
        Me.Parkinglable.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Parkinglable.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Parkinglable.ForeColor = System.Drawing.Color.White
        Me.Parkinglable.Location = New System.Drawing.Point(620, 536)
        Me.Parkinglable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Parkinglable.Name = "Parkinglable"
        Me.Parkinglable.Size = New System.Drawing.Size(134, 41)
        Me.Parkinglable.TabIndex = 13
        Me.Parkinglable.Text = "Parking"
        '
        'Leaselable
        '
        Me.Leaselable.AutoSize = True
        Me.Leaselable.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Leaselable.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Leaselable.ForeColor = System.Drawing.Color.White
        Me.Leaselable.Location = New System.Drawing.Point(363, 536)
        Me.Leaselable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Leaselable.Name = "Leaselable"
        Me.Leaselable.Size = New System.Drawing.Size(103, 41)
        Me.Leaselable.TabIndex = 14
        Me.Leaselable.Text = "Lease"
        '
        'ManagementOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1222, 925)
        Me.Controls.Add(Me.Leaselable)
        Me.Controls.Add(Me.Parkinglable)
        Me.Controls.Add(Me.UnitLabel1)
        Me.Controls.Add(Me.employeeLabel4)
        Me.Name = "ManagementOption"
        Me.Text = "ManagementOption"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents employeeLabel4 As Label
    Friend WithEvents UnitLabel1 As Label
    Friend WithEvents Parkinglable As Label
    Friend WithEvents Leaselable As Label
End Class
