import React from 'react';
import 'C:\\DeepSkilling\\Week7_React\\Handson2_ReactJS-HOL\\Code\\officespacerentalapp\\src\\App.css';

function App() {
  // Step 1: Office Object
  const office = {
    name: "Premium Tech Park",
    rent: 55000,
    address: "Electronic City, Bangalore",
    image: "https://as2.ftcdn.net/jpg/02/04/58/65/1000_F_204586568_KEyNTOwANit3CU6jWZKhOyUR9WMTxUW8.webp"
  };

  // Step 2: List of Offices
  const officeList = [
    { name: "Tech Hub", rent: 40000, address: "HSR Layout" },
    { name: "WorkNest", rent: 65000, address: "Koramangala" },
    { name: "Innov8", rent: 55000, address: "Indiranagar" },
    { name: "WeSpace", rent: 70000, address: "Whitefield" }
  ];

  // Step 3: Style Function
  const rentStyle = (rent) => ({
    color: rent < 60000 ? "red" : "green",
    fontWeight: "bold"
  });

  return (
    <div style={{ padding: "20px", fontFamily: "Arial" }}>
      {/* Page Heading */}
      <h1>Office Space Rental App</h1>

      {/* Office Image */}
      <img src={office.image} alt="Office" style={{ width: "300px", height: "200px" }} />

      {/* Office Details */}
      <h2>{office.name}</h2>
      <p>Address: {office.address}</p>
      <p style={rentStyle(office.rent)}>Rent: ₹{office.rent}</p>

      {/* Office List */}
      <h3>Available Office Spaces:</h3>
      <ul>
        {officeList.map((item, index) => (
          <li key={index} style={{ marginBottom: "15px" }}>
            <strong>{item.name}</strong><br />
            Address: {item.address}<br />
            <span style={rentStyle(item.rent)}>Rent: ₹{item.rent}</span>
          </li>
        ))}
      </ul>
    </div>
  );
}

export default App;
