import React from 'react';

function BookDetails({ show }) {
  if (!show) return null;

  return (
    <div className='details-box'>
      <h2>Book Details</h2>
      <p>Title: React in Action</p>
      <p>Author: Mark T.</p>
      <p>Pages: 300</p>
    </div>
  );
}

export default BookDetails;
