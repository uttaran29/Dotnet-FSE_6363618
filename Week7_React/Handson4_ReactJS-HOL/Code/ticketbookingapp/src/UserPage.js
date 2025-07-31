import React from 'react';

function UserPage() {
  return (
    <div className="content-box">
      <h2>Welcome, User!</h2>
      <p>Book your tickets from the available flights:</p>
      <ul>
        <li>Mumbai → Delhi — ₹4500 <button>Book Now</button></li>
        <li>Bangalore → Kolkata — ₹6000 <button>Book Now</button></li>
        <li>Chennai → Hyderabad — ₹3200 <button>Book Now</button></li>
      </ul>
    </div>
  );
}

export default UserPage;
