# Building

## Windows

- The signing certificate needs to be added to the Certificate Manager ('certmgr')
- The certificate thumbnail needs to be known
- In the JBQQuizMeApp project file, 'PackageCertificateThumbprint' may need to be updated to the current thumbnail
- Make sure that 'Package.appxmanifest' is updated with the correct version

### 64-bit Windows
dotnet publish -f net7.0-windows10.0.19041.0 -c Release /p:RuntimeIdentifierOverride=win10-x64

## Android

- The jbqquizme.keystore needs to be copied to the JBQQuizMeApp project directory
- Make sure you know the password to the keystore file and will be referenced as '[kspassword]'

dotnet publish -f:net7.0-android -c:Release /p:AndroidSigningKeyPass=[kspassword] /p:AndroidSigningStorePass=[kspassword]

## MacOS (Catalyst)

- This needs to be run on a MacOS system
- At this time this will generate an **unsigned** package (.pkg) file

dotnet publish -f net7.0-maccatalyst -c Release /p:CreatePackage=true

## iOS

- This needs to be run on a MacOS system
- 'Archive on Build' is set in the project file
- In the JBQQuizMeApp project file, make sure that '<CodesignKey>' is set to the distribution certificate in Keychain Access on the Mac build host
- In the JBQQuizMeApp project file, make sure that '<CodesignProvision>' is set to the name of the codesign provision in the Apple Developer portal

dotnet publish -f net7.0-ios -c Release /p:CreatePackage=true