import React from 'react';
import "C:\\DeepSkilling\\Week7_React\\Handson1_ReactJS-HOL\\Code\\cricketapp\\src\\App.css"

const T20players = ["Kohli", "Rohit", "Pant", "Gill"];
const RanjiPlayers = ["Sai Sudarshan", "Tilak", "Naman", ""];

const IndianPlayers = () => {
  const mergedPlayers = [...T20players, ...RanjiPlayers];

  const evenPlayers = mergedPlayers.filter((_, index) => index % 2 === 0);
  const oddPlayers = mergedPlayers.filter((_, index) => index % 2 !== 0);

  return (
    <div className="players-container">
      <h2>Merged Players List</h2>
      <ul>
        {mergedPlayers.map((player, index) => (
          <li key={index}>{player}</li>
        ))}
      </ul>

      <h3>Even Team Players (Even Index)</h3>
      <ul>
        {evenPlayers.map((player, index) => (
          <li key={index}>{player}</li>
        ))}
      </ul>

      <h3>Odd Team Players (Odd Index)</h3>
      <ul>
        {oddPlayers.map((player, index) => (
          <li key={index}>{player}</li>
        ))}
      </ul>
    </div>
  );
};

export default IndianPlayers;