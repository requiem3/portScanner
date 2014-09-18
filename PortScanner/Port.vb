Imports System.Net.Sockets
Imports System.Net
Imports System.Threading

Public Class Port

    Dim userIPAddress As String
    Dim userHostName As String
    Dim CallIncrementProgressBar As New MethodInvoker(AddressOf Me.IncrementProgressBar)

    Private Sub Scan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Scan.Click
        ProgressBar1.Minimum = StartCB.Value
        ProgressBar1.Maximum = StopCB.Value
        ProgressBar1.Value = StartCB.Value

        Me.CheckForIllegalCrossThreadCalls = False
        For i As Integer = StartCB.Value To StopCB.Value
            Me.BeginInvoke(CallIncrementProgressBar)
            Dim portThread As New System.Threading.Thread(AddressOf ScanPort)
            portThread.IsBackground = True
            portThread.Start(i)
        Next
    End Sub

    Private Sub ScanPort(ByVal port As Integer)
        Try
            Dim tmpClient As New TcpClient()
            Dim tmpEndPoint As New IPEndPoint(IPAddress.Parse(TB1.Text), port)
            tmpClient.Connect(tmpEndPoint)
            Threading.Thread.Sleep(50)
            If tmpClient.Connected = True Then
                lbPorts.Items.Add("Open Port: " & port)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userHostName = System.Net.Dns.GetHostName()
        userIPAddress = System.Net.Dns.GetHostEntry(userHostName).AddressList(0).ToString()
        TB1.Text = userIPAddress
    End Sub

    Private Sub IncrementProgressBar()
        If ProgressBar1.Value < ProgressBar1.Maximum Then
            ProgressBar1.Value += 1
            Me.Text = "Port Scanner [" & Int((ProgressBar1.Value - ProgressBar1.Minimum) / (ProgressBar1.Maximum - ProgressBar1.Minimum) * 100) & "%]"
        End If
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Form1.Show()
    End Sub
End Class
