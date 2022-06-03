var names = Array(
    "Purus Parturient",
    "Porta Tellus",
    "Vehicula Magna",
    "Reis Olson",
"Mahira Irvine",
"Milli Douglas",
"Kasper Kerr",
"Minahil Preston",
"Cienna Moreno",
"Hawwa Hanson",
"Madeleine Simmons",
"Ria Mcneill",
"Ivan Reeve"
);

function getRandomName() {
    var name = names[Math.floor(Math.random() * names.length)];
    document.getElementById("name").innerHTML = name;
}