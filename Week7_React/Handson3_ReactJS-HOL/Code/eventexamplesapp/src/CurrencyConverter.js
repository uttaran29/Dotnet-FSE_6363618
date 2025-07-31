import React, { useState } from 'react';

function CurrencyConverter() {
  const [rupees, setRupees] = useState('');
  const [euros, setEuros] = useState('');

  const handleSubmit = (e) => {
    e.preventDefault();
    const conversionRate = 0.02;
    const result = parseFloat(rupees) * conversionRate;
    setEuros(result.toFixed(2));
  };

  return (
    <div>
      <h2>Currency Converter</h2>
      <form onSubmit={handleSubmit}>
        <label>
          Rupees:
          <input
            type="number"
            value={rupees}
            onChange={(e) => setRupees(e.target.value)}
            required
          />
        </label>
        <button type="submit">Convert</button>
      </form>

      {euros && (
        <p>Converted Value: €{euros}</p>
      )}
    </div>
  );
}

export default CurrencyConverter;
