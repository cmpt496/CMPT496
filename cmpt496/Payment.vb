﻿Public Class Payment
    Public Fname As String
    Public Lname As String
    Public Tenant_ID As String
    Public TEmail As String
    Public PAmount As String
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        Billing_lease.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        LoadGrid()
    End Sub

    Private Sub LoadGrid()
        'login.SQL.ExecQuery("select * from Payment")

        ''login.SQL.ExecQuery("select * from Client where CLientID = " + idsearch.ToString + "or Name like '%" + searchstr + "%' or Pemail like '%" + searchstr + "%'")
        'DataGridView1.DataSource = login.SQL.DBDS.Tables(0)
        ''Throw New NotImplementedException()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Email.Show()
    End Sub

    'Select distinct Lease.LeaseID, Lease.BID, Unit.UnitID, Tenant.First_name, Tenant.Last_name, Lease.Monthlyrate, Lease.Startdate, Lease.Enddate
    'From Lease,Tenant,Unit Where Lease.TID=Tenant.TID AND Lease.BID=Unit.BID
    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        login.SQL.ExecQuery("select Tenant.First_name, Tenant.Last_name, Tenant.TID, Tenant.Email, Payment.Amount
                             From Tenant, Payment Where Tenant.TID=Payment.TID")
        Fname = login.SQL.DBDS.Tables(0).Rows(0)(0).ToString
        Lname = login.SQL.DBDS.Tables(0).Rows(0)(1).ToString
        Tenant_ID = login.SQL.DBDS.Tables(0).Rows(0)(2).ToString
        TEmail = login.SQL.DBDS.Tables(0).Rows(0)(3).ToString
        PAmount = login.SQL.DBDS.Tables(0).Rows(0)(4).ToString

        Label7.Text = Fname & Lname
        Label8.Text = Tenant_ID
        Label9.Text = TEmail
        Label10.Text = PAmount

    End Sub

End Class