open System.Windows.Forms

type Person = {Name: string; Age: int} // Record data type

let testData = 
    [|
        {Name= "Harry"; Age=37};
        {Name= "July"; Age=41}
    |]


// F# convention is to new up classes that implement IDisposable
let form = new Form(Text = "F# Windows Form")

let dataGrid = new DataGridView(Dock=DockStyle.Fill, DataSource = testData)
form.Controls.Add(dataGrid)

Application.Run(form)