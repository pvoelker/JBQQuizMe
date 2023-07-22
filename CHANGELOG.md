# 'JBQ Quiz Me!' Change Log

Track changes made to the game application.

## Version 0.1.0.0

- Initial alpha version of game
- Known Issue: Multi-line text does not work on the answer buttons (https://github.com/dotnet/maui/issues/9277)

## Version 0.2.0.0

- Fix various questions
- Add information button on main screen
- Enhance quizzing user interface
- Apply MIT license

## Version 0.3.0.0

- First beta version
- Fix issue with accidental clicks when new question is brought up
- Fix layout on Android phones
- Enhance quizzing user interface based on user input
- Clean up product name
- Fix and clean up questions
- Fix a number of build warnings

## Version 0.4.0.0 (app ver 1)

- Second beta version
- First Android build
- Adjust font size in answer buttons based on length of answer text
- Set minimum height on answer buttons to make layout more consistent
- Improve documentation around usage of 10 point questions from Bible Fact-Pak™
- Clean up 'About' window
- Split 'person' category question type
- Further question clean up and add some more wrong answers
- Fix start and end question range on main page

## Version 0.5.0.0 (app ver 2)

- Third beta version
- Lower lighting of candle from 20 to 10 correct answers
- Display how many candles have been lit
- Show annoying frog on wrong answers
- Animate congratulation message when candle is fully lit

## Version 0.6.0.0 (app ver 3)

- Fourth beta version
- Add text to speech for questions and answers
- Save text to speech settings between game runs
- Save question start and end range between game runs

## Version 0.7.0.0 (app ver 4)

- Fifth beta version
- First MacOS build
- Adjust annoying frog to only show some of the time
- Add a cloud the player has to click away on a correct answer
- Clean up SVG files
- Known Issue: Font is smaller on MacOS (https://github.com/dotnet/maui/issues/10622)

## Version 0.8.0.0 (app ver 5)

- Sixth beta version
- Pull code out of quiz view-model into 'question provider'
- Fix issue where question is read while rain cloud is up
- Implement proper UI styles
- Address font size issue on MacOS in UI styles
- Added an 'answer hash' to the question data to make generating wrong answers easier more efficient
- Move decryption of data from provider into repository, which is more appropriate for a repository pattern
- Add information about copyrighted material in the code

## Version 0.9.0.0 (app ver 6)

- Adjust font sizes on quiz page for better viewing on phone sized screens
- Fix app project file so NuGet packages can be updated properly
- BUG: Improve error handling on text-to-speech functionality in order to prevent runtime crashes
- Cancel reading of question when quiz content page is left
- Show version information in Android builds
- Update to .NET 7 with associated package updates
- Numerous UI layout fixes due to update to .NET 7
- Don't show a rain cloud when a candle has been lit
- Known Issue: Workaround put in place for error during release builds - https://github.com/dotnet/maui/issues/12515

## Version 0.9.1.0 (app ver 7)
- BUG: Temporary fix for an issue with 'About' on MacOS (Catalyst): https://github.com/dotnet/maui/issues/11766
- BUG: Fix user interface issue on MacOS (Catalyst) where a grid with no visible content was blocking clicks on the answer buttons
- BUG: Fix spacing issue with answers on MacOS (Catalyst)

## Version 0.10.0.0 (app ver 8)
- Known Issue: App has trouble running for the first time on Windows 10 (https://github.com/dotnet/maui/issues/12080). Work around is to run the app as an administrator one time.
- MAJOR: Switch from poking the frog and cloud to Lottie animations for correct and wrong answers

## Version 0.10.1.0 (app ver 9)
- Build for updated MAUI.NET version 7.0.59
- FIX: First time run on Windows 10 corrected in MAUI 7.0.59 included in VS 17.4.5 (https://github.com/dotnet/maui/issues/12080)
- FIX: Build issue fixed (https://github.com/dotnet/maui/issues/12515)

## Version 0.10.2.0 (app ver 10)
- Fix user interface issues in dark mode
- Change how candle is sized so it looks better
- POST RELEASE NOTE: This version failed validation on the Apple App Store on iOS 16.3.1

## Version 0.10.3.0 (app ver 11)
- Use compiled bindings in XAML
- Removed unused email provider from code
- 
- ## Version 0.10.4.0 (app ver 12)
- Fix drop shadow on candle
- Minor library update
- Add phonetic spelling