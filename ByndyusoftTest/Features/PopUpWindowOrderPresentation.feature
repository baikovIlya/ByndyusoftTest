Feature: PopUpWindowOrderPresentation

@contacts
Scenario: Add two numbers
	Given Open Google web page
	When Input "Byndysoft" in textbox search
	And Click button Search In Google
	And Click on first link
	And Click on button OrderPresentation
	Then PopUp window should appear
	And Email in PopUp window should match "sales@byndyusoft.com"
	And Phone number in PopUp window should match "8 800 775-15-21"