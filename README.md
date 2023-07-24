# NoteTaker Application

The NoteTaker C# class represents a simple application that allows users to take and manage notes. It is a Windows Forms application built using the Form class and utilizes a DataGridView control to display and manage the notes in a tabular format. The application allows users to add, edit, delete, and view notes.

## Class Properties and Fields
* DataTable notes: This field represents a DataTable object that stores the notes in a tabular format with two columns: "Title" and "Note". Each row in the table corresponds to a single note.

* bool editing: This boolean field indicates whether the user is currently editing an existing note (true) or creating a new note (false).

## Class Constructor
* The NoteTaker class constructor initializes the form by calling InitializeComponent() to set up the user interface.
## NoteTaker_Load Event Handler
* The NoteTaker_Load event handler is triggered when the form is loaded.
* It initializes the notes DataTable by adding two columns: "Title" and "Note".
* The DataGridView control preNotes is bound to the notes DataTable as its data source to display the notes.
## deleteBtn_Click Event Handler
* The deleteBtn_Click event handler is triggered when the user clicks the "Delete" button.
* It attempts to delete the currently selected note from the notes DataTable.
* If no valid note is selected or an error occurs during deletion, a message is displayed to the console.
## saveBtn_Click Event Handler
* The saveBtn_Click event handler is triggered when the user clicks the "Save" button.
* If the user is in editing mode, it updates the title and content of the currently selected note in the notes DataTable.
* If the user is not in editing mode, it creates a new row in the notes DataTable with the entered title and note content.
* After saving the note, it clears the text boxes (txtTitle and txtNote) and sets the editing flag to false.
## LoadBtn_Click Event Handler
* The LoadBtn_Click event handler is triggered when the user clicks the "Load" button.
* It loads the selected note's title and content into the text boxes (txtTitle and txtNote) for editing.
* It sets the editing flag to true.
## newNoteBtn_Click Event Handler
* The newNoteBtn_Click event handler is triggered when the user clicks the "New Note" button.
* It clears the text boxes (txtTitle and txtNote) to create a new blank note.
## preNotes_CellContentDoubleClick Event Handler
* The preNotes_CellContentDoubleClick event handler is * triggered when the user double-clicks a cell in the DataGridView (preNotes).
* It loads the double-clicked note's title and content into the text boxes (txtTitle and txtNote) for editing.
* It sets the editing flag to true.

This application provides basic functionality to manage notes using a DataGridView for display. However, it lacks error handling and data persistence, which could be added to enhance the user experience and ensure data is saved even after closing the application.