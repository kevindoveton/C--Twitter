import * as React from 'react';
import { Component } from 'react';

import './style.scss';
import { UserIcon } from '../../Components/UserIcon';
import { TweetModal } from '../../Components/TweetModal';
import { Loader } from '../../Components/Loader';

class SingleTweet extends Component<{match: iPropMatch}> {
  state: {
    tweet?: iNewsfeedRes
  };

  constructor(props: any) {
    super(props);
    this.state = {};
  }

  componentDidMount() {
    const id = this.props.match.params.id;
    fetch(process.env.REACT_APP_API + '/tweets/' + id)
    .then(r => r.json())
    .then(r => {
      this.setState({ tweet: r, hasTweet: true });
    })
    .catch((e) => {
      console.error('single-tweet: ' + e);
    });
  }

  render() {
    return (
      <div className="single-tweet-container">
        {
          this.state.tweet === undefined
            ? <Loader />
            : <TweetModal tweet={this.state.tweet} />
        }
      </div>
    );
  }
}

export {
  SingleTweet
};
