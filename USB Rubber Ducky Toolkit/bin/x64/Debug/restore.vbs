''Author: Ryan Guarascia
''Desciption: C# no longer supports GetObject, CreateObject I figured running a seperate script would help. Also, it has its own error checking.
''Must be ran in Admin, which permission is asked for upon launch.
''Keeping code...
    If WScript.Arguments.Count = 0 Then
	    Set objShell = CreateObject("Shell.Application")
	    objShell.ShellExecute "wscript.exe", Chr(34) & WScript.ScriptFullName & Chr(34) & " Run", , "runas", 1
    Else
	    GetObject("winmgmts:\\.\root\default:Systemrestore").CreateRestorePoint InputBox("Enter a descriptive name for the restore point:","Create Restore Point", "Restore from RubberDucky Emulator"), 0, 100
	    Msgbox("Restore Created")
    End If

