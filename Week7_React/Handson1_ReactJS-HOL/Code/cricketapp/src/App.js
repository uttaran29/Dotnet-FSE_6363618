import React from 'react';
import ListofPlayers from '../src/components/IndianPlayers';
import IndianPlayers from '../src/components/ListofPlayers';

function App() {
  const flag = true; // Set to false to show IndianPlayers

  return (
    <div className="App">
      <h1>Cricket App</h1>
      {flag ? <ListofPlayers /> : <IndianPlayers />}
    </div>
  );
}

export default App;
