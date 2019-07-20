// Creates a custom staff style (pre-requisite for Lead sheet script)
// This is in my template now so not much need for this... 

//process all open

staff tool
strike alt "s"
strike "y"
wait 1 second

//dropdown "Hide Chords" near "Available Styles:"
//click "Delete"

//wait 3 seconds   //testing

// new style
expect to click "New"
strike shift tab
strike shift tab
strike shift tab
type "Hide Chords"
uncheck "Chords"

button "Ok"