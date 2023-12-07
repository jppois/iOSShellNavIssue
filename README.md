# iOSShellNavIssue
VS2022 .NET 8 MAUI iOS only Shell navigation issue when more than five tab items used

Note that PageOnePage has all the info added below!

- First Create a new Visual Studio Project based on the .NET MAUI App template with .NET 8.0.3"
- Add ten pages to the project"
- Create one tabbar with ten 'ShellContent' items, one for each page, in the AppShell.xaml page"
- In the Landing page, add 10 buttons pointing to their respective page. Botton 1 to page 1, etc."
- Windows Platform: Test accessibility of each page using the tabs, the 'more' menu items, and each buttons on the landing page - all should work as expected landing on the correct page!"
NOTE: Windows 10 and Windows 11 based machines are behaving as expected"
- Android Platform: Test accessibility of each page using the tabs, the 'more' menu items, and each buttons on the landing page - all should work as expected landing on the correct page!"
NOTE: Android Emulator Pixel 5 - API 30... behaves as expected as well as physical devices"
- iOS Platform: First Access all pages using the tabs and More menu items.  They all should work as expected!"
- iOS Platform: Second access the pages using the 'Buttons'. Depending on the device screen size, you may only see four tabs - Landing, PageOnePage, PageTwoPage, and PageThreePage. All other pages are behind the More menu"
- iOS Platform: For all 'Buttons' that point to pages that are in the More menu, they will bring the More menu instead of the actual page.  Once the button was clicked, then the More menu item no longer behaves the way it is expected to be for that More menu item."
- iOS Platform: For example: Click on Button pointing to PageFourPage on the landing page. The More menu appear. Now click on the More menu PageFourPage item, the item become selected BUT the page no longer appear."
