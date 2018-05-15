import * as React from 'react';
import { Component } from 'react';
import { Link } from 'react-router-dom';

import { Tweet } from '../../Components/Tweet';
import { UserSummary } from '../../Components/UserSummary';
import { WhoToFollow } from '../../Components/WhoToFollow';
import { TwitterDetails } from '../../Components/TwitterDetails';
import { Header } from '../../Components/Header';
import { NewTweet } from '../../Components/NewTweet';

import './style.scss';

class Newsfeed extends Component {
  state: {
    tweets: Array<iNewsfeedRes>;
    user?: iUser;
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
      this.setState({
        tweets: r.tweets,
        user: r.user
      });
    })
    .catch((e) => {
      console.error('newsfeed: ' + e);
    });
  }

  componentDidMount() {
    document.title = 'Newsfeed | Twityer';
  }

  render() {
    const { tweets } = this.state;
    return (
      <div className="newsfeed container">
        <div className="container--lhs">
          <div className="newsfeed--summary">
            {typeof this.state.user !== 'undefined' && (<UserSummary user={this.state.user} />)}
          </div>
        </div>
        <div className="container--c">
          <div className="newsfeed--tweets">
            <NewTweet />
            {tweets.map((t, index, arr) => (
              <Link to={'/tweet/' + t.id} key={index}>
                <Tweet tweet={t} user={t.user} />
              </Link>
            ))}
          </div>
        </div>
        <div className="container--rhs">
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
