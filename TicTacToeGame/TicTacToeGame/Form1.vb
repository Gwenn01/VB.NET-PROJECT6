Imports System.Security.Cryptography.Pkcs

Public Class Form1
    Dim PlayerOneScore = 0
    Dim PlayerTwoScore = 0
    Dim tic As New TicTacToe
    Dim player = True
    Dim btnClick(8) As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buttonClicked()
    End Sub
    Private Sub buttonClicked()
        ' this function refer if the button is already click
        For i = 0 To btnClick.Length - 1
            btnClick(i) = False
        Next
    End Sub
    Private Sub btnBoard1_Click(sender As Object, e As EventArgs) Handles btnBoard1.Click
        ' base condition  refer if the button is already click
        If btnClick(0) = True Then
            Return
        End If
        'check if the user player one or player two
        If player = True Then
            tic.playerOne(0, 0)
            player = False
            btnClick(0) = True
        Else
            tic.playerTwo(0, 0)
            player = True
            btnClick(0) = True
        End If
        display()
        ' check the winner
        If tic.isPlayerOneWin() Then
            lblWinner.Text = "Player 1 Winner!"
            displayReset()
            playerOneScores()
        End If
        If tic.isPlayerTwoWin() Then
            lblWinner.Text = "Player 2 Winner!"
            displayReset()
            playerTwoScores()
        End If
        ' check if its draw
        If isDraw() Then
            lblWinner.Text = "Its a Draw!"
            displayReset()
        End If
    End Sub

    Private Sub btnBoard2_Click(sender As Object, e As EventArgs) Handles btnBoard2.Click
        ' base condition  refer if the button is already click
        If btnClick(1) = True Then
            Return
        End If
        'check if player one or player two
        If player = True Then
            tic.playerOne(0, 1)
            player = False
            btnClick(1) = True
        Else
            tic.playerTwo(0, 1)
            player = True
            btnClick(1) = True
        End If
        display()
        ' check the winner
        If tic.isPlayerOneWin() Then
            displayReset()
            playerOneScores()
            lblWinner.Text = "Player 1 Winner!"
        End If
        If tic.isPlayerTwoWin() Then
            displayReset()
            playerTwoScores()
            lblWinner.Text = "Player 2 Winner!"
        End If
        ' check if its draw
        If isDraw() Then
            displayReset()
            lblWinner.Text = "Its a Draw!"
        End If
    End Sub

    Private Sub btnBoard3_Click(sender As Object, e As EventArgs) Handles btnBoard3.Click
        ' base condition  refer if the button is already click
        If btnClick(2) = True Then
            Return
        End If
        'check if player one or player two
        If player = True Then
            tic.playerOne(0, 2)
            player = False
            btnClick(2) = True
        Else
            tic.playerTwo(0, 2)
            player = True
            btnClick(2) = True
        End If
        display()
        ' check the winner
        If tic.isPlayerOneWin() Then
            displayReset()
            playerOneScores()
            lblWinner.Text = "Player 1 Winner!"
        End If
        If tic.isPlayerTwoWin() Then
            displayReset()
            playerTwoScores()
            lblWinner.Text = "Player 2 Winner!"
        End If
        ' check if its draw
        If isDraw() Then
            displayReset()
            lblWinner.Text = "Its a Draw!"
        End If
    End Sub

    Private Sub btnBoard4_Click(sender As Object, e As EventArgs) Handles btnBoard4.Click
        ' base condition  refer if the button is already click
        If btnClick(3) = True Then
            Return
        End If
        'check if player one or player two
        If player = True Then
            tic.playerOne(1, 0)
            player = False
            btnClick(3) = True
        Else
            tic.playerTwo(1, 0)
            player = True
            btnClick(3) = True
        End If
        display()
        ' check the winner
        If tic.isPlayerOneWin() Then
            displayReset()
            playerOneScores()
            lblWinner.Text = "Player 1 Winner!"
        End If
        If tic.isPlayerTwoWin() Then
            displayReset()
            playerTwoScores()
            lblWinner.Text = "Player 2 Winner!"
        End If
        ' check if its draw
        If isDraw() Then
            displayReset()
            lblWinner.Text = "Its a Draw!"
        End If
    End Sub

    Private Sub btnBoard5_Click(sender As Object, e As EventArgs) Handles btnBoard5.Click
        ' base condition  refer if the button is already click
        If btnClick(4) = True Then
            Return
        End If
        'check if player one or player two
        If player = True Then
            tic.playerOne(1, 1)
            player = False
            btnClick(4) = True
        Else
            tic.playerTwo(1, 1)
            player = True
            btnClick(4) = True
        End If
        display()
        ' check the winner
        If tic.isPlayerOneWin() Then
            displayReset()
            playerOneScores()
            lblWinner.Text = "Player 1 Winner!"
        End If
        If tic.isPlayerTwoWin() Then
            displayReset()
            playerTwoScores()
            lblWinner.Text = "Player 2 Winner!"
        End If
        ' check if its draw
        If isDraw() Then
            displayReset()
            lblWinner.Text = "Its a Draw!"
        End If
    End Sub

    Private Sub btnBoard6_Click(sender As Object, e As EventArgs) Handles btnBoard6.Click
        ' base condition  refer if the button is already click
        If btnClick(5) = True Then
            Return
        End If
        'check if player one or player two
        If player = True Then
            tic.playerOne(1, 2)
            player = False
            btnClick(5) = True
        Else
            tic.playerTwo(1, 2)
            player = True
            btnClick(5) = True
        End If
        display()
        ' check the winner
        If tic.isPlayerOneWin() Then
            displayReset()
            playerOneScores()
            lblWinner.Text = "Player 1 Winner!"
        End If
        If tic.isPlayerTwoWin() Then
            displayReset()
            playerTwoScores()
            lblWinner.Text = "Player 2 Winner!"
        End If
        ' check if its draw
        If isDraw() Then
            displayReset()
            lblWinner.Text = "Its a Draw!"
        End If
    End Sub

    Private Sub btnBoard7_Click(sender As Object, e As EventArgs) Handles btnBoard7.Click
        ' base condition  refer if the button is already click
        If btnClick(6) = True Then
            Return
        End If
        'check if player one or player two
        If player = True Then
            tic.playerOne(2, 0)
            player = False
            btnClick(6) = True
        Else
            tic.playerTwo(2, 0)
            player = True
            btnClick(6) = True
        End If
        display()
        ' check the winner
        If tic.isPlayerOneWin() Then
            displayReset()
            playerOneScores()
            lblWinner.Text = "Player 1 Winner!"
        End If
        If tic.isPlayerTwoWin() Then
            displayReset()
            playerTwoScores()
            lblWinner.Text = "Player 2 Winner!"
        End If
        ' check if its draw
        If isDraw() Then
            displayReset()
            lblWinner.Text = "Its a Draw!"
        End If
    End Sub

    Private Sub btnBoard8_Click(sender As Object, e As EventArgs) Handles btnBoard8.Click
        ' base condition  refer if the button is already click
        If btnClick(7) = True Then
            Return
        End If
        'check if player one or player two
        If player = True Then
            tic.playerOne(2, 1)
            player = False
            btnClick(7) = True
        Else
            tic.playerTwo(2, 1)
            player = True
            btnClick(7) = True
        End If
        display()
        ' check the winner
        If tic.isPlayerOneWin() Then
            displayReset()
            playerOneScores()
            lblWinner.Text = "Player 1 Winner!"
        End If
        If tic.isPlayerTwoWin() Then
            displayReset()
            playerTwoScores()
            lblWinner.Text = "Player 2 Winner!"
        End If
        ' check if its draw
        If isDraw() Then
            displayReset()
            lblWinner.Text = "Its a Draw!"
        End If
    End Sub

    Private Sub btnBoard9_Click(sender As Object, e As EventArgs) Handles btnBoard9.Click
        ' base condition  refer if the button is already click
        If btnClick(8) = True Then
            Return
        End If
        'check if player one or player two
        If player = True Then
            tic.playerOne(2, 2)
            player = False
            btnClick(8) = True
        Else
            tic.playerTwo(2, 2)
            player = True
            btnClick(8) = True
        End If
        display()
        If tic.isPlayerOneWin() Then
            displayReset()
            playerOneScores()
            lblWinner.Text = "Player 1 Winner!"
        End If
        If tic.isPlayerTwoWin() Then
            displayReset()
            playerTwoScores()
            lblWinner.Text = "Player 2 Winner!"
        End If
        ' check if its draw
        If isDraw() Then
            displayReset()
            lblWinner.Text = "Its a Draw!"
        End If
    End Sub
    ' scores
    Private Sub playerOneScores()
        PlayerOneScore = PlayerOneScore + 1
        lblScoreOne.Text = PlayerOneScore
    End Sub
    Private Sub playerTwoScores()
        PlayerTwoScore = PlayerTwoScore + 1
        lblScoreTwo.Text = PlayerTwoScore
    End Sub
    ' check if its draw, check every button if its already click
    Private Function isDraw()
        For i As Integer = 0 To btnClick.Length - 1 Step 1
            If Not btnClick(i) Then
                Return False
            End If
        Next
        Return True
    End Function
    ' if one of the player wins reset the all and board
    Public Sub displayReset()
        'reset out 2d array board
        tic.emptyBoard()
        ' reset the button cliked
        buttonClicked()
        ' reset player if O or X
        player = True
        ' reset the display board
        btnBoard1.Text = ""
        btnBoard2.Text = ""
        btnBoard3.Text = ""
        btnBoard4.Text = ""
        btnBoard5.Text = ""
        btnBoard6.Text = ""
        btnBoard7.Text = ""
        btnBoard8.Text = ""
        btnBoard9.Text = ""
    End Sub
    'display out board
    Private Sub display()
        btnBoard1.Text = tic.getBoard(0, 0)
        btnBoard2.Text = tic.getBoard(0, 1)
        btnBoard3.Text = tic.getBoard(0, 2)
        btnBoard4.Text = tic.getBoard(1, 0)
        btnBoard5.Text = tic.getBoard(1, 1)
        btnBoard6.Text = tic.getBoard(1, 2)
        btnBoard7.Text = tic.getBoard(2, 0)
        btnBoard8.Text = tic.getBoard(2, 1)
        btnBoard9.Text = tic.getBoard(2, 2)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'reset out 2d array board
        tic.emptyBoard()
        ' reset the button cliked
        buttonClicked()
        ' reset player if O or X
        player = True
        'reset score
        lblScoreOne.Text = ""
        PlayerOneScore = 0
        lblScoreTwo.Text = ""
        PlayerTwoScore = 0
        ' reset the display board
        btnBoard1.Text = ""
        btnBoard2.Text = ""
        btnBoard3.Text = ""
        btnBoard4.Text = ""
        btnBoard5.Text = ""
        btnBoard6.Text = ""
        btnBoard7.Text = ""
        btnBoard8.Text = ""
        btnBoard9.Text = ""
        'reset winner 
        lblWinner.Text = ""
    End Sub
End Class
Public Class TicTacToe
    Dim board(2, 2) As String
    'this funtion is for eampty the board fo every reset and won
    Public Sub emptyBoard()
        For i = 0 To board.GetLength(0) - 1
            For j = 0 To board.GetLength(1) - 1
                board(i, j) = ""
            Next
        Next
    End Sub
    'to put the user input from the button into our 2d array
    Public Sub playerOne(row As Integer, col As Integer)
        board(row, col) = "X"
    End Sub
    'to put the user input from the button into our 2d array
    Public Sub playerTwo(row As Integer, col As Integer)
        board(row, col) = "O"
    End Sub
    ' check the winner
    Public Function isPlayerOneWin() As Boolean
        ' check horizontal
        If board(0, 0) = "X" And board(0, 1) = "X" And board(0, 2) = "X" Then
            Return True
        End If
        If board(1, 0) = "X" And board(1, 1) = "X" And board(1, 2) = "X" Then
            Return True
        End If
        If board(2, 0) = "X" And board(2, 1) = "X" And board(2, 2) = "X" Then
            Return True
        End If
        ' check vertical
        If board(0, 0) = "X" And board(1, 0) = "X" And board(2, 0) = "X" Then
            Return True
        End If
        If board(0, 1) = "X" And board(1, 1) = "X" And board(2, 1) = "X" Then
            Return True
        End If
        If board(0, 2) = "X" And board(1, 2) = "X" And board(2, 2) = "X" Then
            Return True
        End If
        ' check the exis
        If board(0, 0) = "X" And board(1, 1) = "X" And board(2, 2) = "X" Then
            Return True
        End If
        If board(0, 2) = "X" And board(1, 1) = "X" And board(2, 0) = "X" Then
            Return True
        End If
        Return False
    End Function
    ' check the winner
    Public Function isPlayerTwoWin() As Boolean
        ' check horizontal
        If board(0, 0) = "O" And board(0, 1) = "O" And board(0, 2) = "O" Then
            Return True
        End If
        If board(1, 0) = "O" And board(1, 1) = "O" And board(1, 2) = "O" Then
            Return True
        End If
        If board(2, 0) = "O" And board(2, 1) = "O" And board(2, 2) = "O" Then
            Return True
        End If
        ' check vertical
        If board(0, 0) = "O" And board(1, 0) = "O" And board(2, 0) = "O" Then
            Return True
        End If
        If board(0, 1) = "O" And board(1, 1) = "O" And board(2, 1) = "O" Then
            Return True
        End If
        If board(0, 2) = "O" And board(1, 2) = "O" And board(2, 2) = "O" Then
            Return True
        End If
        ' check the exis
        If board(0, 0) = "O" And board(1, 1) = "O" And board(2, 2) = "O" Then
            Return True
        End If
        If board(0, 2) = "O" And board(1, 1) = "O" And board(2, 0) = "O" Then
            Return True
        End If
        Return False
    End Function
    'return our board to display in out user interface 
    Public Function getBoard(row As Integer, col As Integer)
        Return board(row, col)
    End Function
End Class
