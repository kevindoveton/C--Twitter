import * as React from 'react';
import { Component } from 'react';

import './style.scss';

class TwitterDetails extends Component {
  render() {
    const year = 2018;
    return (
      <div className="twitter-details">
        <div className="links">
          <span>&copy; {year} Twityer About Help Centre Terms Privacy policy Cookies Ads info 
          Brand Blog Status Apps Jobs Marketing Businesses Developers
          </span>
        </div>
        <div className="advertise">
          <span>Advertise with twityer</span>
        </div>
      </div>
    );
  }
}

export {
  TwitterDetails
};
