import React from 'react';

const players = [
  { name: "Rohit", score: 85 },
  { name: "Virat", score: 95 },
  { name: "Pant", score: 12 },
  { name: "Surya", score: 35 },
  { name: "Dubey", score: 3 },
  { name: "Hardik", score: 24 },
  { name: "Axar", score: 9 },
  { name: "Jadeja", score: 8 },
  { name: "Kuldeep", score: 0 },
  { name: "Arshdeep", score: 0 },
  { name: "Bumrah", score: 0 }
];

const ListofPlayers = () => {
  const lowScorers = players.filter(player => player.score < 70);

  return (
    <div>
      <h2>All Players</h2>
      <ul>
        {players.map((player, index) => (
          <li key={index}>{player.name} - {player.score}</li>
        ))}
      </ul>

      <h2>Players with score less than 70</h2>
      <ul>
        {lowScorers.map((player, index) => (
          <li key={index}>{player.name}</li>
        ))}
      </ul>
    </div>
  );
};

export default ListofPlayers;
