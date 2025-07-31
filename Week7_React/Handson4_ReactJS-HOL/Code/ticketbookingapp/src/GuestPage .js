import React from 'react';

function GuestPage() {
  return (
    <div className="content-box">
      <h2>Welcome, Guest!</h2>
      <p>Here are some flight options for you to explore:</p>
      <ul>
        <li>Mumbai → Delhi — ₹4500</li>
        <li>Bangalore → Kolkata — ₹6000</li>
        <li>Chennai → Hyderabad — ₹3200</li>
      </ul>
    </div>
  );
}

export default GuestPage;
