const apiUrl = "https://localhost:7156/api/Notes";
let notes = [];
let selectedNote = null;

function getList() {
    $("#notes").html("");

    $.get(apiUrl, data => {
        notes = data;

        for (const note of notes) {
            let a = $("<a/>")
                .addClass("list-group-item")
                .addClass("list-group-item-action")
                .text(note.title)
                .attr("href", "#!")
                .attr("data-id", note.id)
                .click((e) => {
                    e.preventDefault();
                    open(note);
                });

            if (note.id == selectedNote?.id) {
                selectedNote = note;
                a.addClass("active");
            }

            $("#notes").append(a);
        }
    });
}

function open(note) {
    selectedNote = note;
    $("#txtTitle").val(note.title);
    $("#txtContent").val(note.content);
    $("#notes>a").removeClass("active");
    $(`#notlar>a[data-id=${note.id}]`).addClass("active");
}

function save(event) {
    event.preventDefault();

    if (selectedNote) {
        let note = { ...selectedNote };
        note.title = $("#txtTitle").val();
        note.content = $("#txtContent").val();
        $.ajax({
            type: "put",
            url: apiUrl + "/" + note.id,
            contentType: "application/json",
            data: JSON.stringify(note),
            success: function (data) {
                selectedNote = data;
                getList();
            }
        });
    }
    else {
        let note = {};
        note.title = $("#txtTitle").val();
        note.content = $("#txtContent").val();
        $.ajax({
            type: "post",
            url: apiUrl,
            contentType: "application/json",
            data: JSON.stringify(note),
            success: function (data) {
                selectedNote = data;
                getList();
            }
        });
    }
}

function newNote() {
    selectedNote = null;
    $("#notlar>a").removeClass("active");
    $("#txtTitle").val("");
    $("#txtContent").val("");
}

function deleteNote() {
    if (selectedNote) {
        $.ajax({
            type: "delete",
            url: apiUrl + "/" + selectedNote.id,
            success: function () {
                newNote();
                getList();
            }
        });
    }
}

$("#frmNote").submit(save);
$("#btnNew").click(newNote);
$("#btnDelete").click(deleteNote);

getList();