' Name:         Donut Shoppe Project
' Purpose:      Display the subtotal, sales tax, and total due.
' Programmer:   Jesus M Alvarado Gonzalez 06/17/2021

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'Display the subtotal, salex tax, and total due.

        Dim decSubTotal As Decimal
        Dim decSalexTax As Decimal
        Dim decTotal As Decimal

        'Calculate subtotal.

        ''CalcSubtotal(decSubtotal)
        'Calculate salex tax.
        '' decSalexTax = GetSalesTax(decSubtotal)
        ''decSalexTax = Math.Round(decSalexTax, 2)

        'Calculate total due.
        decTotal = decSubTotal + decSalexTax

        'Display subtotal, sales tax and total due.
        lblSubtotal.Text = decSubTotal.ToString("N2")
        lblSalexTax.Text = decSalexTax.ToString("N2")
        lblTotalDue.Text = decTotal.ToString("N2")


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ''Close aplication
        Dim response As Integer
        response = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = vbYes Then
            Me.Close()
        End If

    End Sub
End Class
