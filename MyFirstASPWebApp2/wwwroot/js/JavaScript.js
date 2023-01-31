$("#submit").click( function () {
    let iassignment = $("#assignment").val() * 0.5
    let igroup = $("#gp").val() * 0.1;
    let iquiz = $("#quiz").val() * 0.1;
    let imid = $("#mid").val() * 0.1;
    let ifinal = $("#final").val() * 0.1;
    let iIntex = $("#intex").val() * 0.1;

    let ifinalGrade = iassignment + igroup + iquiz + imid + ifinal + iIntex;
    let letterGrade = "";
    if (ifinalGrade >= 94) {
        $("#results").html("Final Grade: A");
    } else if (94 > ifinalGrade >= 90) {
        $("#results").html("Final Grade: A-");
    } else if (ifinalGrade >= 87) {
        $("#results").html("Final Grade: B+");
    } else if (ifinalGrade >= 84) {
        $("#results").html("Final Grade: B");
    } else if (ifinalGrade >= 80) {
        $("#results").html("Final Grade: B-");
    } else if (ifinalGrade >= 77) {
        $("#results").html("Final Grade: C+");
    } else if (ifinalGrade >= 74) {
        $("#results").html("Final Grade: C");
    } else if (ifinalGrade >= 70) {
        $("#results").html("Final Grade: C-");
    } else if (ifinalGrade >= 67) {
        $("#results").html("Final Grade: D+");
    } else if (ifinalGrade >= 64) {
        $("#results").html("Final Grade: D");
    } else if (ifinalGrade >= 60) {
        $("#results").html("Final Grade: D-");
    } else {
        $("#results").html("Final Grade: E");
    }
})