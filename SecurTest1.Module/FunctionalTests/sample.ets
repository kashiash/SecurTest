;#DropDB SecurTest1EasyTest

#Application SecurTest1.Win
#Application SecurTest1.Web
#IfDef SecurTest1.Win

*Action About...
 
*Action OK

#EndIf

#IfDef SecurTest1.Web
!Action Navigation(My Details)
#EndIf
