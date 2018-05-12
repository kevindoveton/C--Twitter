import * as React from 'react';
import { Component } from 'react';
import { Link } from 'react-router-dom';

import { Tweet } from '../../Components/Tweet';
import { UserSummary } from '../../Components/UserSummary';
import { WhoToFollow } from '../../Components/WhoToFollow';
import { TwitterDetails } from '../../Components/TwitterDetails';

import './style.scss';

class Newsfeed extends Component {
  state: {
    tweets: Array<iNewsfeedRes>
  };
  
  constructor(props: any) {
    super(props);
    this.state = {
      tweets: []
    };
  }

  componentWillMount() {
    fetch(process.env.REACT_APP_API + '/newsfeed/')
    .then(r => r.json())
    .then(r => {
      this.setState({ tweets: r });
    })
    .catch((e) => {
      console.error('newsfeed: ' + e);
    });
  }

  render() {
    const { tweets } = this.state;
    return (
      <div className="newsfeed">
        <div className="newsfeed--summary">
          <UserSummary />
        </div>
        <div className="newsfeed--tweets">
          {tweets.map(t => (
            <Link to={'/tweet/' + t.id} key={t.id}>
              <Tweet key={t.id} tweet={t} user={t.user} />
            </Link>
          ))}
        </div>
        <div className="newsfeed--rhs">
          <div className="newsfeed--who-to-follow">
            <WhoToFollow />
          </div>
          <div className="newsfeed--twitter-details">
            <TwitterDetails />
          </div>
        </div>
      </div>
    );
  }
}

export {
  Newsfeed
};