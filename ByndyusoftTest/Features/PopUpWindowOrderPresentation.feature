Feature: PopUpWindowOrderPresentation

PopUp window with contacts, that appears after clicking on the button Order Presentation.

@contacts
Scenario: Add two numbers
	Given Open Google web page
	When Input "Byndyusoft" in textbox search
	And Click button Search In Google
	And Click on first link
	And Click on button OrderPresentation
	Then PopUp window should appear
	And Email in PopUp window should match "sales@byndyusoft.com"
	And Phone number in PopUp window should match "8 800 775-15-21"