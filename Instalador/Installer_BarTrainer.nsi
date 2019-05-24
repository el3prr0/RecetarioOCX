
!define MUI_PRODUCT "BarTrainer Ver. 1.0"
!define MUI_FILE "Recetariocx"
!define MUI_VERSION ""
!define MUI_BRANDINGTEXT "BarTrainer Ver. 1.0"

Name "BarTrainer"


; The file to write
OutFile "Install_BarTrainer.exe"
InstallDir $PROGRAMFILES\BarTrainer
DirText "Instalando BarTrainer, un producto de Sonora Tech"


Section "Install"
  ;se sobreescribira el archivo
  SetOverwrite on

  ; Set output path to the installation directory.
  SetOutPath $INSTDIR



  File /r D:\Projects\RecetarioOCX\Recetariocx\bin\Release\
  
  CreateShortCut "$DESKTOP\${MUI_PRODUCT}.lnk" "$INSTDIR\Release\${MUI_FILE}.exe" ""



SectionEnd