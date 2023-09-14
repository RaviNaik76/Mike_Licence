
Module nudi
    Declare Function NudiStartKeyboardEngine Lib "Kannada-Nudi.dll" Alias "_NudiStartKeyboardEngineVB@12" (ByVal isGlobal As Boolean, ByVal isMonolingual As Integer, ByVal needTrayIcon As Boolean) As Boolean
    Declare Function NudiStopKeyboardEngine Lib "Kannada-Nudi.dll" Alias "_NudiStopKeyboardEngineVB@0" () As Boolean
    Declare Sub NudiTurnOnScrollLock Lib "Kannada-Nudi.dll" Alias "_NudiTurnOnScrollLockVB@0" ()
    Declare Sub NudiTurnOffScrollLock Lib "Kannada-Nudi.dll" Alias "_NudiTurnOffScrollLockVB@0" ()
End Module
