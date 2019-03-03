function populate() {
    if(quiz.isEnded()) {
        showScores();
    }
    else {
        // show question
        var element = document.getElementById("question");
        element.innerHTML = quiz.getQuestionIndex().text;

        // show options
        var choices = quiz.getQuestionIndex().choices;
        for(var i = 0; i < choices.length; i++) {
            var element = document.getElementById("choice" + i);
            element.innerHTML = choices[i];
            guess("btn" + i, choices[i]);
        }

        showProgress();
    }
};

function guess(id, guess) {
    var button = document.getElementById(id);
    button.onclick = function() {
        quiz.guess(guess);
        populate();
    }
};


function showProgress() {
    var currentQuestionNumber = quiz.questionIndex + 1;
    var element = document.getElementById("progress");
    element.innerHTML = "Question " + currentQuestionNumber + " of " + quiz.questions.length;
};

function showScores() {
    var gameOverHTML = "<h1>Result</h1>";
    gameOverHTML += "<h2 id='score'> Your scores: " + quiz.score + "</h2>";
    var element = document.getElementById("quiz");
    element.innerHTML = gameOverHTML;
};

// create questions
var questions = [
    new Question("What is the Capital city of Drc (Democratic Republic of Congo)?", ["Brazzaville", "Kinshasa","Durban"], "Kinshasa"),
    new Question("What is the Capital city of SA (South Africa)?", ["Rabat", "Johannesburg", "Pretoria"], "Pretoria"),
    new Question("What is the Capital city of RCA (Republic Center Africa)?", ["Bangui", "Bandundu","Luanda"], "Bangui"),
    new Question("What is the Capital city of INDIA?", ["Grugram", "FaridAbad", "Delhi"], "Delhi"),
    new Question("What is the Capital city of Pakistan?", ["Karachi", "Lahore", "Islamabad"], "Islamabad")
];

// create quiz
var quiz = new Quiz(questions);

// display quiz
populate();





