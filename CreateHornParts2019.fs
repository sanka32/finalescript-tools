//process all open


// ---- make sure we are on score first
strike alt "o"
strike "s"


// ----- 1. Create Instruments in Score Manager
// ctrl k always opens ScoreManager, even if it's already open
strike ctrl "k"
wait 2 seconds


// Add Instrument...
click "Add Instrument..."
//tab 2

//All / Woodwinds / Tenor Sax
click "All"
click "Brass"
click "Trumpet in Bb"
strike enter
wait 2 seconds
click "Instrument List"

strike ctrl "k"
wait 1 second
strike ctrl "k"
wait 1 second



// Add Instrument...
click "Add Instrument..."
//tab 2

//All / Woodwinds / Tenor Sax
click "All"
click "Woodwinds"
click "Alto Sax"
strike enter
wait 2 seconds
click "Instrument List"

strike ctrl "k"
wait 1 second
strike ctrl "k"
wait 1 second

// Add Instrument...
click "Add Instrument..."
//tab 2

//All / Brass / Bass Trombone
click "All"
click "Brass"
click "Bass Trombone"
strike enter
wait 3 seconds

strike ctrl "k"
// menuitem will toggle scoremanager, so this is a hack to make sure it's closed
menitem "Window\Score Manager"





//   change to score edit, display concert pitches
strike alt "o"
strike "s"

display in concert pitch



// TODO copy text markings from Vocals to new staves

// need to ensure filter is on
//menu item "Edit Filter..."
//click "None"
//check "Text blocks (assigned to measures)"
//click "Ok"
// copy 
//select staff 1
//copy
// paste 
//select staff 2
//paste
//select staff 3
//paste
//select staff 4
//paste