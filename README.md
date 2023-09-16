# Flappy Bird AI with Unity and ML-Agents

![flapygif](https://github.com/Sookeyy-12/FlappyBird-Unity-MLAgents/assets/82956207/f8bfa42a-d792-4e83-b026-a8efe439dd9a)

### Overview
This project demonstrates the training of an artificial intelligence (AI) agent to master the popular mobile game "Flappy Bird" using Unity and the ML-Agents library. By combining reinforcement learning and the Proximal Policy Optimization (PPO) algorithm, I've empowered an AI to autonomously navigate the challenging Flappy Bird environment, achieving impressive results.

### Features
- Reinforcement Learning: Leveraged the power of reinforcement learning to teach the AI agent how to play Flappy Bird effectively.
- ML-Agents Library: The ML-Agents library provides a flexible framework for training agents in Unity environments.
- Proximal Policy Optimization (PPO): PPO is employed as the training algorithm to optimize the AI agent's performance.
- Unity Environment: The Flappy Bird game environment is created in Unity, providing an interactive training platform.

### Configurations
```yaml
# .yaml
behaviors:
  FlappyBird:
    trainer_type: ppo
    hyperparameters:
      batch_size: 64
      buffer_size: 2048
      learning_rate: 3e-4
      beta: 5e-3
      epsilon: 0.2
      lambd: 0.95
      num_epoch: 3
      learning_rate_schedule: linear
      beta_schedule: constant
      epsilon_schedule: linear
    network_settings:
      normalize: false
      hidden_units: 128
      num_layers: 2
    reward_signals:
        extrinsic:
          strength: 1.0
          gamma: 0.99
        curiosity:
          strength: 0.01
          gamma: 0.99
          encoding_size: 64
    max_steps: 5000000
    time_horizon: 64
    summary_freq: 10000
```

### Observation Space

The Flappy Bird AI agent relies on ray perception sensors as its "eyes" to perceive the game environment. These sensors emit rays to gather essential data like detecting:
- lower pipe
- upper pipe
- ground
- ceiling
- and pipes ahead

enabling the agent to make informed decisions during gameplay. These observations are crucial for training the agent to navigate the Flappy Bird environment effectively.

<img width="275" alt="image" src="https://github.com/claylo/yaml-include/assets/82956207/89ad6671-4478-4487-b21d-d51ac29c8dbd">
