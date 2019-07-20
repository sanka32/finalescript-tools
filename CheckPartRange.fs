// Check a part range but with a pre-saved custom range for each staff


no selection
select staff "Tenor Sax"

apply plugin "Check Range..."

// notes
select "Beginner" from list "Range Class" 
type "C6" near "High Note"

button "Check"

// wait for dialog again
wait for click

// notes bass trom  e2  d4
select "Beginner" from list "Range Class" 
type "D4" near "High Note"
type "E2" near "Low Note"


// check
button "Check"