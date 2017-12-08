Sub INaujas()
' INaujas Macro
' Perejna i naujo pacinto uzrasima
    Sheets("Naujas").Select
    Range("B3").Select
    Application.DisplayAlerts = False
    ActiveSheet.ShowDataForm
    Application.DisplayAlerts = True
End Sub
