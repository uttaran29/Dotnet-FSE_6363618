import "../stylesheets/mystyle.css";

function CalculateScore() {
  const name = "Uttaran Sarkar";
  const university = "KIIT University";
  const total = 469;
  const goal = 500;

  const average = (total / goal) * 100;

  return (
    <div className="score-box">
      <h2>Student Score Summary</h2>
      <p><strong>Name:</strong> {name}</p>
      <p><strong>University:</strong> {university}</p>
      <p><strong>Total:</strong> {total}</p>
      <p><strong>Goal:</strong> {goal}</p>
      <p><strong>Score:</strong> {average.toFixed(2)}%</p>
    </div>
  );
}

export default CalculateScore;