import React, { useState } from 'react';
import './App.css';
import CurrencyConverter from './CurrencyConverter';

function App() {
  const [counter, setCounter] = useState(0);

  const sayHello = () => {
    console.log("Hello! This is a static message.");
  };

  const handleIncrement = () => {
    setCounter(prev => prev + 1);
    sayHello();
  };

  const handleDecrement = () => {
    setCounter(prev => prev - 1);
  };

  const sayMessage = (msg) => {
    alert(msg);
  };

  const handleClick = (event) => {
    alert("I was clicked");
    console.log("Synthetic Event:", event);
  };

  return (
    <div className="App">
      <h1>React Event Handling Example</h1>
      
      <h2>Counter: {counter}</h2>
      <button onClick={handleIncrement}>Increment</button>
      <button onClick={handleDecrement}>Decrement</button>

      <hr />

      <button onClick={() => sayMessage("Welcome!")}>Say Welcome</button>

      <hr />

      <button onClick={handleClick}>Synthetic Event Button</button>

      <hr />

      <CurrencyConverter />
    </div>
  );
}

export default App;
