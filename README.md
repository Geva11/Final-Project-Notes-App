NOTES AND TODOLISTS APP 

(Program.cs) - Main Program - Here, all the users are able to register, login, exit and view all notes of all registered users (but will not be able to show its contents
for the privacy of each users registered with saved notes). In this class, we can also see the LoggedIn method that as long as the user is login, the user can choose
choose if the user wants to create notes, view notes, create todolists, and logout when a user is done using the app.

(User.cs, Note.cs, TodoLists.cs) - In this class, all codes for storing the details of each user saved informations from user's username, password, created notes, and
created todolists is stored here and used when a certain information is needed to be called out, either to be check or to be display.

(UserAccount.cs) - In this part of the project we can found the register and login. In register, the user will be ask for username and password to be registered (If the user
input a blank username and function, it will not be registered.). In Login, the user will need to input an existing/registered username and password which will be return in
the LoggingIn method in Program.cs to be check if the entered username and password is right for the user to proceed using the app.

(ViewAllNotes.cs) - This class ables to show/display all notes of each resgistered users with saved notes in their account.

(NotesManager.cs) - This class contains the work for creating notes(user can input title and content), displaying title of notes then viewing selected note's content, 
and editing the content of the note, deleting the note, and going back in the LoggedIn method in the Program.cs where the user will be asked again if the user wants to 
create notes, view notes, create todolists, and logout when a user is done using the app.

(NotesFunctions.cs) - In this class, we can see some functions where used in NotesManager like in editing note where the current content of selected note will be replaced 
with the new inputed content and the user will be immediately ask if the user wants to edit the note again, delete the note (the note open by the user will be deleted. If there are no 
remaining notes after deleting the note deleted by the user, the system will display that there are no remaining notes and will asked the user if the user wants to 
make a new note or go back (LoggedIn method in Program.cs). But if there remaining note, the system will display the remaining notes and the user will be ask which
one the user wants to open and when a certain note is open, the user will be immediately ask if the user wants to edit the content of the note, delete the note or go back 
(LoggedIn method in Program.cs).) or go back (LoggedIn method in
Program.cs). 

(TodoListManager.cs) - This class contains the work for creating todolists(user can input title and multiple tasks), displaying title of todolists then viewing selected 
todolist's task(s), and adding 1 or more tasks, deleting certain task, deleting the selected todolist and going back in the LoggedIn method in the Program.cs where the user 
will be asked again if the user wants to create notes, view notes, create todolists, and logout when a user is done using the app.

(TodoListsFunctions.cs) - In this class, we can see some functions where used in TodoListManager.cs like in ADDING MORE TASK(S) (then the system will display the new added
tasks with the old tasks inputed by the user and will be asked again if the user wants to add task(s), delete a task, delete the todolists, or go back (LoggedIn method in
Program.cs)), DELETE A CERTAIN TASK (after a task deleted, the system will display the remaiming tasks and will be asked again if the user wants to add task(s), 
delete a task, delete the todolists, or go back (LoggedIn method inProgram.cs)), DELETE THE TODOLIST (the todolist open by the user will be deleted. If there are no 
remaining Todolist after deleting the todolist deleted by the user, the system will display that there are no remaining Todolist and will asked the user if the user wants to 
make a new todolist or go back (LoggedIn method in Program.cs). But if there remaining todolist, the system will display the remaining todolist and the user will be ask which
one the user wants to open and when a certain todolist is open, the user will be immediately ask if the user wants to add task(s), delete a task or go back 
(LoggedIn method in Program.cs).) or GO BACK (LoggedIn method in Program.cs).
