﻿Public Class Renting
    Public sql As Sqlcon
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Main.Show()

    End Sub

    Private Sub Renting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'login.SQL.ExecQuery("select distinct Stalltype from Parking")
        'For i = 0 To login.SQL.DBDS.Tables(0).Rows.Count - 1
        '    parking.Items.Add(login.SQL.DBDS.Tables(0).Rows(i)(0).ToString)
        'Next
        login.SQL.ExecQuery("select DoorNumber, Unit.TypeID,Floors,UnitType.Bedrooms, UnitType.Bathrooms,UnitType.Squarefeet,UnitType.Den,UnitType.Patio,UnitType.Price from Unit, UnitType 
                            where Unit.TypeID =UnitType.TypeID and Unit.BID = " + Main.Building.Text.ToString + " and Unit.RentStatus = 'Vacant'")
        ListBox1.DataSource = login.SQL.DBDS.Tables(0)
        ListBox1.DisplayMember = "DoorNumber"
        ListBox1.ValueMember = "TypeID"
        ListBox1.SelectedIndex = 0
        doornumber.Text = ListBox1.SelectedValue.ToString

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        login.SQL.ExecQuery("select DoorNumber, Unit.TypeID,Floors,UnitType.Bedrooms, UnitType.Bathrooms,UnitType.Squarefeet,UnitType.Den,UnitType.Patio,UnitType.Price from Unit, UnitType 
                            where Unit.TypeID =UnitType.TypeID and UnitType.Bedrooms = " + Bedroom.SelectedItem.ToString + " and UnitType.Bathrooms = " + Bathroom.SelectedItem.ToString + " and Unit.BID = " + Main.Building.Text.ToString + " and Unit.RentStatus = 'Vacant'")
        ListBox1.DataSource = login.SQL.DBDS.Tables(0)
        ListBox1.DisplayMember = "DoorNumber"
        ListBox1.ValueMember = "TypeID"
        'ListBox1.SelectedIndex = 0
        doornumber.Text = ListBox1.SelectedValue.ToString
        login.SQL.ExecQuery("select * from UnitType where TypeID = " + doornumber.Text.ToString)
        price.Text = login.SQL.DBDS.Tables(0).Rows(0)(3).ToString()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim dm As Integer
        doornumber.Text = ListBox1.SelectedValue.ToString
        dm = doornumber.Text
        login.SQL.ExecQuery("select * from UnitType where TypeID = " + dm.ToString)
        price.Text = login.SQL.DBDS.Tables(0).Rows(0)(3).ToString()
        den.Text = login.SQL.DBDS.Tables(0).Rows(0)(2).ToString()
        If login.SQL.DBDS.Tables(0).Rows(0)(3).ToString() = 0 Then
            patio.Text = "Yes"
        Else
            patio.Text = "No"
        End If
        'patio.Text = login.SQL.DBDS.Tables(0).Rows(0)(7).ToString()
        sq.Text = login.SQL.DBDS.Tables(0).Rows(0)(4).ToString()
    End Sub
End Class