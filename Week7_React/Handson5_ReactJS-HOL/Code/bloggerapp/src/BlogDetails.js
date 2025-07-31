import React from 'react';

function BlogDetails({ show }) {
  return (
    <>
      {show ? (
        <div className='details-box'>
          <h2>Blog Details</h2>
          <p>Title: Learning React</p>
          <p>Author: Sarah D.</p>
          <p>Published: July 2025</p>
        </div>
      ) : null}
    </>
  );
}

export default BlogDetails;
