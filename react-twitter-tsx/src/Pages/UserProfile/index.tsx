import * as React from 'react';
import { Component } from 'react';
import { Link } from 'react-router-dom';

import './style.scss';
import { TwitterDetails } from '../../Components/TwitterDetails';
import { UserSummary } from '../../Components/UserSummary';
import { Tweet } from '../../Components/Tweet';

class UserProfile extends Component<{match: iPropMatch}> {
  state: {
    tweets: Array<iNewsfeedRes>;
    user?: iUser;
    userId: string;
  };

  constructor(props: any) {
    super(props);
    this.state = {
      tweets: [],
      userId: String(this.props.match.params.id)
    };
  }

  componentWillMount() {
    fetch(process.env.REACT_APP_API + '/user/' + this.state.userId)
    .then(r => r.json())
    .then(r => {
      this.setState({
        user: r
      });
    })
    .catch((e) => {
      console.error('newsfeed: ' + e);
    });

    fetch(process.env.REACT_APP_API + '/user/' + this.state.userId + '/feed/')
    .then(r => r.json())
    .then(r => {
      this.setState({
        tweets: r
      });
    })
    .catch((e) => {
      console.error('newsfeed: ' + e);
    });
  }

  // componentDidMount() {
  // }

  render() {
    const { tweets } = this.state;
    return (
      <div className="user-profile container">
        <div className="container--lhs">
          {typeof this.state.user !== 'undefined' && (<UserSummary user={this.state.user} />)}
        </div>
        <div className="container--c">
          {tweets.map(t => (
              <Link to={'/tweet/' + t.id} key={t.id}>
                <Tweet key={t.id} tweet={t} user={t.user} />
              </Link>
            ))}
        </div>
        <div className="container--rhs">
          <TwitterDetails />
        </div>
      </div>
    );
  }
}

export {
  UserProfile
};
