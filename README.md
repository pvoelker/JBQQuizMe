# JBQQuizMe

Simple quizzing game for kids based on Junior Bible Quizzing (JBQ) 10-point questions

## Building

### Windows

- The signing certificate needs to be added to the Certificate Manager ('certmgr')
- The certificate thumbnail needs to be known
- In the JBQQuizMeApp project file, 'PackageCertificateThumbprint' may need to be updated to the current thumbnail

#### 32-bit (not working yet)
dotnet publish -f net6.0-windows10.0.19041.0 -c Release -r win10-x86

#### 64-bit Windows
dotnet publish -f net6.0-windows10.0.19041.0 -c Release /p:RuntimeIdentifierOverride=win10-x64

### Android

- The jbqquizme.keystore needs to be copied to the JBQQuizMeApp project directory
- Make sure you know the password to the keystore file and will be referenced as '[kspassword]'

dotnet publish -f:net6.0-android -c:Release /p:AndroidSigningKeyPass=[kspassword] /p:AndroidSigningStorePass=[kspassword]

## Credits

- Pastor Michelle Redmon from Faith Chapel of Overland Park for transcribing the questions
- My son Matthew for helping with beta testing
