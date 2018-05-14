import * as React from 'react';
import { Component } from 'react';

import './style.scss';

class TwitterDetails extends Component {
  render() {
    const year = (new Date()).getFullYear();
    const links = [
      { 'text': year + ' Twityer'},
      { 'text': 'About', link: '/about' },
      { 'text': 'Help centre' },
      { 'text': 'Privacy policy' },
      { 'text': 'Cookies' },
      { 'text': 'Ads info' },
      { 'text': 'Brand' },
      { 'text': 'Blog' },
      { 'text': 'Status' },
      { 'text': 'Apps' },
      { 'text': 'Jobs' },
      { 'text': 'Marketing' },
      { 'text': 'Businesses' },
      { 'text': 'Developers' }
    ];
    return (
      <div className="twitter-details">
        <div className="links">
          {links.map((l, index, arr) => (
            <span key={index}>
              {l.link 
                ? <a href={l.link}>{l.text}</a>
                : l.text
              }
              </span>
          ))}
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
