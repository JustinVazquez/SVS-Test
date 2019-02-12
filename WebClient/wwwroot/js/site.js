let connection = new signalR.HubConnectionBuilder()
    .withUrl("https://localhost:44361/Main")
    .build();
var x;
connection.start().then(() => test(1));

async function test(p1) {
    x = await connection.invoke("Send", p1);
    document.getElementById("test").innerHTML = x;

}

function test2(p1) {
    connection.invoke("Send", p1).then(function (s) {

        document.getElementById("test").innerHTML = s;
    });
}


function alle() {
    connection.invoke("Send2");
}


connection.on("test3", function () {
    document.getElementById("test").innerHTML = "Alle";
});









